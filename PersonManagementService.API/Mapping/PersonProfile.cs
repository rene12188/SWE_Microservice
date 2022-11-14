using AutoMapper;
using PersonManagementService.DB.Model;
using PersonManagementService.Model;
using FinancialProductsDto = PersonManagementService.Model.FinancialProductsDto;

namespace PersonManagementService.Mapping;

public class PersonProfile : Profile
{
    public PersonProfile()
    {
        CreateMap<PersonDto, Person>().ReverseMap();
        CreateMap<FinancialProducts, FinancialProductsDto>().ReverseMap();
    }
}