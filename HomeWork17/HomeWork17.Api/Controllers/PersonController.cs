using HomeWork17.Application.Persons.Contracts;
using HomeWork17.Domain.Persons;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeWork17.Api.Controllers
{
    public class PersonController : Controller
    {
        public readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("GetAllPersons")]
        public async Task<ActionResult<List<Person>>> GetAllPersons()
        {
            var data = await _personService.GetAllPersons();
            return Ok(data);
        }

        [HttpPost("CreatePersonData")]
        public async Task<ActionResult> CreatePersonData([FromBody] Person person)
        {
            var validate = new PersonValidator();
            var result = validate.Validate(person);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors[0].ErrorMessage);
            }
            await _personService.AddPerson(person);
            return RedirectToAction("GetAllPersons");
        }
        [HttpGet("GetPersonById/{id}")]
        public async Task <ActionResult<Person>> GetPersonById([FromRoute] int id)
        {
            var person = await _personService.GetPersonById(id);
            return Ok(person);
        }
        [HttpGet("GetPersonBySalary")]
        public async Task <ActionResult<List<Person>>> GetPersonBySalary([FromQuery] double salary)
        {
            var list = await _personService.FindPerson(x => x.Salary > salary);
            return Ok(list);
        }

        [HttpDelete("Delete/{id}")]
        public async Task <ActionResult> DeletePerson([FromRoute] int id)
        {
            await _personService.DeletePerson(id);
            var data = await _personService.GetAllPersons();
            return Ok(data);
        }

        [HttpPut("Update/{id}")]
        public async Task<ActionResult<List<Person>>> UpdatePerson([FromRoute] int id, Person person)
        {
            await _personService.UpdatePerson(id,person);
            var data = await _personService.GetAllPersons();
            return Ok(data);
        }
    }
}
