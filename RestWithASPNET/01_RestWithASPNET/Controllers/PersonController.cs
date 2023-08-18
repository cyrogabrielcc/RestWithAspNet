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

    }
}