using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.API.Dto;

namespace University.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {

        [HttpGet("All")]
        public IActionResult GetUniversity()
        {
            //List of university
            var allUniversity = new List<University.API.Models.University>()
            {
                new University.API.Models.University()
                {
                    Id = 1,
                    Name = "FSHN",
                    City = "Tirana",
                    NumDepartments = 5,

                },
                new University.API.Models.University()
                {
                     Id = 2,
                    Name = "UPT",
                    City = "Tirana",
                    NumDepartments = 4,
                },
            };

            return Ok(allUniversity);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetUniversityById(int id)
        {
            var newUniversity = new Models.University()
            {
                Id = 1,
                Name = "FSHN",
                City = "Tirana",
                NumDepartments = 5,
            };

            return Ok(newUniversity);
        }


        [HttpPost]
        public IActionResult AddNewUniversity([FromBody] PostUniversityDto payload)
        {
            return Ok(payload);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateUniversity([FromBody] PutUniversityDto payload, int id)
        {
            return Ok(payload);
        }


        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteUniversity(int id)
        {
            return Ok();
        }

    }
}
