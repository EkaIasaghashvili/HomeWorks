using FluentAssertions;
using FluentAssertions.Execution;
using HomeWork17.Application.Persons.Contracts;
using HomeWork17.Application.Repository;
using HomeWork17.Domain.Persons;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HomeWork17.Application.Tests
{
    public class PersonServiceTests
    {
        private readonly Mock<IRepository<Person>> _personRepository;
        private readonly IPersonService _personService;
        public PersonServiceTests()
        {
            _personRepository = new Mock<IRepository<Person>>();
            _personService = new PersonService(_personRepository.Object);
        }

        [Fact]
        public async Task WhenPersonNotNull_ShouldAddPerson()
        {
            var personObject = PersonObject.GetPersonObject();

            Func<Task> action = async () => await _personService.AddPerson(personObject);

            await action.Should().NotThrowAsync();
        }

        [Fact]
        public async Task WhenPersonIsNull_ShouldThrowArgumentNullException()
        {
            Person personObject = null;

            Func<Task> action = async () => await _personService.AddPerson(personObject);

            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task WhenPersonExists_ShouldDelete()
        {
            var personObject = PersonObject.GetPersonObject();
            _personRepository.Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync(personObject);

            Func<Task> action = async () => await _personService.DeletePerson(personObject.Id);

            await action.Should().NotThrowAsync();
        }

        [Fact]
        public async Task WhenPersonExisxt_ShouldFind()
        {
            var personList = new List<Person>()
            {
                PersonObject.GetPersonObject(),
            };

            Expression<Func<Person, bool>> predicate = x => x.Salary > 100;
            _personRepository.Setup(x => x.Find(It.IsAny<Expression<Func<Person, bool>>>()))
                .ReturnsAsync(personList);

            var result = await _personService.FindPerson(predicate);

            using(new AssertionScope())
            {
                result.Should().BeOfType<List<Person>>();
            }
        }

        [Fact]
        public async Task WhenPersonsExisxt_ShouldReturnPersonsList()
        {
            var personList = new List<Person>()
            {
                PersonObject.GetPersonObject(),
            };

            _personRepository.Setup(x => x.GetAllAsync(It.IsAny<string>()))
                .ReturnsAsync(personList);
           
            var result = await _personService.GetAllPersons();

            using (new AssertionScope())
            {
                result.Should().BeOfType<List<Person>>();
            }
        }

        [Fact]
        public async Task WhenPersonExisxt_ShouldReturnPerson()
        {
            var personObject = PersonObject.GetPersonObject();

            _personRepository.Setup(x => x.GetByIdAsync(It.IsAny<int>()))
                 .ReturnsAsync(personObject);

            var result = await _personService.GetPersonById(1);
            using (new AssertionScope())
            {
                result.Should().BeOfType<Person>();
            }
        }

        [Fact]
        public async Task WhenPersonExisxt_ShouldUpdatePerson()
        {
            var personObject = PersonObject.GetPersonObject();

            var newPerson = PersonObject.GetNewPersonObject();

            _personRepository.Setup(x => x.GetByIdAsync(It.IsAny<int>()))
                 .ReturnsAsync(personObject);

            personObject.Update(newPerson);

            _personRepository.Setup(x => x.UpdateAsync(personObject))
                .Returns(Task.CompletedTask);

            Func<Task> action = async () => await _personService.UpdatePerson(1, newPerson);

            await action.Should().NotThrowAsync();
        }
    }
}
