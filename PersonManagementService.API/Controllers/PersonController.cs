using Microsoft.AspNetCore.Mvc;
using PersonManagementService.Model;

namespace PersonManagementService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<PersonDto> AllPerson()
        {
            throw new NotImplementedException();
        } 
        
        [HttpGet]
        [Route("{id:guid}")]
        public PersonDto GetPersonById(Guid id)
        {
            throw new NotImplementedException();
        }  
        
        
        [HttpPost]
        public PersonDto CreatePerson(PersonDto person)
        {
            throw new NotImplementedException();
        }  
        
        [HttpPut]
        [Route("{id:guid}")]
        public PersonDto UpdatePerson(Guid id, PersonDto person)
        {
            throw new NotImplementedException();
        }  
        
        [HttpDelete]
        [Route("{id:guid}")]
        public PersonDto DeletePersonById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}