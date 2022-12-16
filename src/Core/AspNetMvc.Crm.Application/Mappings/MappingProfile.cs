using AspNetMvc.Crm.Application.Dtos;
using AspNetMvc.Crm.Application.Dtos.Customer;
using AspNetMvc.Crm.Application.Dtos.Employee;
using AspNetMvc.Crm.Domain.Entities;
using AutoMapper;

namespace AspNetMvc.Crm.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap: Customer nesnesini CustomerDto'ya dönüştürürme ayarını yapar.
            //ReverseMap: CustomerDto'yu Customer nesnesine dönüştürürme ayarını yapar.
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Request, RequestDto>().ReverseMap();
        }
    }
}
