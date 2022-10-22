using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonManagementService.DB;
using PersonManagementService.DB.Model;
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
            return _mapper.Map<IList<Person>, IEnumerable<PersonDto>>(_repository.GetAllPersons());
        }

        [HttpGet]
        [Route("{pid:guid}")]
        public PersonDto GetPersonById(Guid pid)
        {
            return _mapper.Map<Person, PersonDto>(_repository.GetPersonById(pid));

        }


        [HttpPost]
        public Guid CreatePerson([FromBody]PersonDto person)
        {
            if (person == null)
            {
                throw new NullReferenceException();
            }
            return _repository.CreatePerson(_mapper.Map<PersonDto, Person>(person));
        }

        [HttpPut]
        [Route("{pid:guid}")]
        public Guid UpdatePerson(Guid pid, PersonDto person)
        {
            return _repository.UpdatePerson(pid,_mapper.Map<PersonDto, Person>(person));
        }

        [HttpDelete]
        [Route("{pid:guid}")]
        public Guid DeletePersonById(Guid pid)
        {
            return _repository.DeletePerson(pid);
        }
    }
}