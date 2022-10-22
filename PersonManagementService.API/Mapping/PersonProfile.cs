using AutoMapper;
using PersonManagementService.DB.Model;
using PersonManagementService.Model;

namespace PersonManagementService.Mapping;

public class PersonProfile : Profile
{
    public PersonProfile()
    {
        CreateMap<PersonDto, Person>().ReverseMap();
    }
}