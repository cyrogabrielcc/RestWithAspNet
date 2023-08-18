using _01_RestWithASPNET.Models;
using _01_RestWithASPNET.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace _01_RestWithASPNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("{id}")]
        public IActionResult GetPerson(long id)
        {
            var personFound = _personService.FindById(id);
            if (personFound is null) return NotFound();
            return Ok(personFound);
        }

        [HttpGet]
        public IActionResult GetAllPersons()
        {
            return Ok(_personService.FindAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person is null) return BadRequest();
            return Ok(_personService.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person is null) return BadRequest();
            return Ok(_personService.Update(person));
        }

         [HttpDelete]
        public IActionResult Delete(long id)
        {
            var personFound = _personService.FindById(id);
            if (personFound is null) return BadRequest();
            return Ok(_personService.Update(personFound));
        }
    }
}