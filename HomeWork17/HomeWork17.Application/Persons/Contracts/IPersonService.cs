using HomeWork17.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17.Application.Persons.Contracts
{
    public interface IPersonService
    {
        Task<List<Person>> GetAllPersons();
        Task<List<Person>> FindPerson(Expression<Func<Person, bool>> predicate);
        Task<Person> GetPersonById(int id);
        Task AddPerson(Person person);
        Task UpdatePerson(int id,Person person);
        Task DeletePerson(int id);
    }
}
