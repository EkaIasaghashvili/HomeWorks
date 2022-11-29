using HomeWork17.Application.Repository;
using HomeWork17.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17.Application.Persons.Contracts
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }
        public async Task AddPerson(Person person)
        {
            await _personRepository.AddAsync(person);
        }

        public async Task DeletePerson(int id)
        {
           var person = await _personRepository.GetByIdAsync(id); 
           await _personRepository.DeleteAsync(person);
        }

        public async Task<IReadOnlyList<Person>> FindPerson(Expression<Func<Person, bool>> predicate)
        {
            return await _personRepository.Find(predicate);
        }
        

        public async Task<IReadOnlyList<Person>> GetAllPersons()
        {
          return await _personRepository.GetAllAsync(nameof(Address));
        }

        public async Task<Person> GetPersonById(int id)
        {
            return await _personRepository.GetByIdAsync(id);
        }

        public async Task UpdatePerson(int id, Person person)
        {
            var updatePerson = await _personRepository.GetByIdAsync(id);
            updatePerson.Update(person);
            await _personRepository.UpdateAsync(updatePerson);
        }
    }
}
