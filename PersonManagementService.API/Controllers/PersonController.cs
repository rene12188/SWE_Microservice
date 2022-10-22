using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonManagementService.DB;
using PersonManagementService.Model;

namespace PersonManagementService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly PersonRepository _repository;
        private readonly IMapper _mapper;
        
        public PersonController(ILogger<PersonController> logger, PersonRepository repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
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