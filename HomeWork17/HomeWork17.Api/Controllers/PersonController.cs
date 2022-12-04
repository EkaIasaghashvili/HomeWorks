using HomeWork17.Application.Persons.Contracts;
using HomeWork17.Domain.Persons;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeWork17.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        public readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [Authorize(Roles = "User"), HttpGet("GetAllPersons")]
        public async Task<ActionResult<List<Person>>> GetAllPersons()
        {
            var data = await _personService.GetAllPersons();
            return Ok(data);
        }

        [Authorize(Roles = "User"), HttpPost("CreatePersonData")]
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
        [Authorize(Roles = "User"), HttpGet("GetPersonById/{id}")]
        public async Task <ActionResult<Person>> GetPersonById([FromRoute] int id)
        {
            var person = await _personService.GetPersonById(id);
            return Ok(person);
        }
        [Authorize(Roles = "User"), HttpGet("GetPersonBySalary")]
        public async Task <ActionResult<List<Person>>> GetPersonBySalary([FromQuery] double salary)
        {
            var list = await _personService.FindPerson(x => x.Salary > salary);
            return Ok(list);
        }

        [Authorize(Roles = "Admin"), HttpDelete("Delete/{id}")]
        public async Task <ActionResult> DeletePerson([FromRoute] int id)
        {
            await _personService.DeletePerson(id);
            var data = await _personService.GetAllPersons();
            return Ok(data);
        }

        [Authorize(Roles = "Admin"), HttpPut("Update/{id}")]
        public async Task<ActionResult<List<Person>>> UpdatePerson([FromRoute] int id, Person person)
        {
            await _personService.UpdatePerson(id,person);
            var data = await _personService.GetAllPersons();
            return Ok(data);
        }
    }
}
