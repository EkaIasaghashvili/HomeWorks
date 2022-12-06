using FluentAssertions;
using FluentAssertions.Execution;
using HomeWork17.Api.Controllers;
using HomeWork17.Application.Persons.Contracts;
using HomeWork17.Application.Repository;
using HomeWork17.Domain.Persons;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HomeWork17.Api.Tests
{
    public class PersonControllerTests
    {
        private readonly Mock<IPersonService> _personService;
        private readonly PersonController _personController;

        public PersonControllerTests()
        {
            _personService = new Mock<IPersonService>();
            _personController = new PersonController(_personService.Object);
        }

        [Fact]
        public async Task WhenPersonsExisxt_ShouldReturnPersonsList()
        {
            var personList = PersonObject.GetPersonList();

            _personService.Setup(x => x.GetAllPersons())
                .ReturnsAsync(personList);

            var result = await _personController.GetAllPersons();

            using (new AssertionScope())
            {
                result.Should().BeOfType<ActionResult<List<Person>>>();
            }
        }

        [Fact]
        public async Task WhenPersonIsValid_ShouldAddPerson()
        {
            var personObject = PersonObject.GetPersonObject();

            Func<Task> action = async () => await _personController.CreatePersonData(personObject);

            await action.Should().NotThrowAsync();
        }

        [Fact]
        public async Task WhenPersonIsNotValid_ShouldThrowArgumentNullException()
        {
            var personObject = PersonObject.GetPersonObject();
            personObject.FirstName = string.Empty;

            var result = await _personController.CreatePersonData(personObject);

            result.Should().BeOfType(typeof(BadRequestObjectResult));
            //Assert.IsType<BadRequestObjectResult>(result);
        }


        [Fact]
        public async Task WhenPersonExist_ShouldReturnPerson()
        {
            var personObject = PersonObject.GetPersonObject();

            _personService.Setup(x => x.GetPersonById(It.IsAny<int>()))
                 .ReturnsAsync(personObject);

            var result = await _personController.GetPersonById(1);

            using (new AssertionScope())
            {
                result.Should().BeOfType<ActionResult<Person>>();
            }
        }

        [Fact]
        public async Task WhenPersonExisxt_ShouldFind()
        {
            var personList = new List<Person>()
            {
                PersonObject.GetPersonObject(),
            };

            double salary = 10;

            Expression<Func<Person, bool>> predicate = x => x.Salary > salary;
            _personService.Setup(x => x.FindPerson(predicate))
                .ReturnsAsync(personList);

            var result = await _personController.GetPersonBySalary(salary);

            using (new AssertionScope())
            {
                result.Should().BeOfType<ActionResult<List<Person>>>();
            }
        }

        [Fact]
        public async Task WhenPersonExists_ShouldDelete()
        {
            var personObject = PersonObject.GetPersonObject();

            var result = await _personController.DeletePerson(personObject.Id);

            _personService.Setup(x => x.GetAllPersons())
                .ReturnsAsync(new List<Person>() { personObject });

            using (new AssertionScope())
            {
                result.Should().BeOfType<ActionResult<List<Person>>>();
            }
        }

        [Fact]
        public async Task WhenPersonExisxt_ShouldUpdatePerson()
        {
            var person = PersonObject.GetNewPersonObject();

            var result = await _personController.UpdatePerson(1, person);

            _personService.Setup(x => x.GetAllPersons())
                .ReturnsAsync(new List<Person>() { person });

            using (new AssertionScope())
            {
                result.Should().BeOfType<ActionResult<List<Person>>>();
            }
        }
    }
}
