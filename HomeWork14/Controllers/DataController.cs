using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using HomeWork14.Models;
using HomeWork14.Validation;
using HomeWork14.Contracts;
using System.Linq;

namespace HomeWork14.Controllers
{
    public class DataController : Controller
    {
        private readonly IFile _file;

        public DataController(IFile file)
        {
            _file = file;
        }

        [HttpGet("GetFileData")]
        public ActionResult<List<PersonData>> GetFileData()
        {
            var result = _file.Read();
            return result;
        }

        [HttpPost("CreatePersonData")]
        public ActionResult<List<PersonData>> CreatePersonData(PersonData newData)
        {
            var validateDate = new ValidateDate();
            var result = validateDate.Validate(newData);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors[0].ErrorMessage);
            }

            var list = _file.Read();

            list.Add(newData);

            _file.Write(list);
            return _file.Read();
        }

        [HttpGet("GetPersonDataById/{id}")]
        public ActionResult<PersonData> GetPersonDataById([FromRoute] int id)
        {
            var list = _file.Read();
            return list[id];
        }

        [HttpGet("GetPersonDataBySalary")]
        public ActionResult<List<PersonData>> GetPersonDataBySalary([FromQuery] double salary)
        {
            var list = _file.Read();
            return list.Where(x => x.Salary > salary).ToList();
        }

        [HttpDelete("Delete/{id}")]
        public ActionResult<List<PersonData>> DeletePersonData([FromRoute] int id)
        {
            var list = _file.Read();
            list.RemoveAt(id);
            _file.Write(list);
            return list;
        }

        [HttpPut("Update/{id}")]
        public ActionResult<List<PersonData>> UpdatePersonData([FromRoute] int id, [FromBody] PersonData newData)
        {
            var list = _file.Read();

            list[id] = newData;
            _file.Write(list);
            return list;
        }
    }
}
