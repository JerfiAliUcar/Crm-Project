using AspNetMvc.Crm.Application.Dtos.Customer;
using AspNetMvc.Crm.Application.Dtos.Employee;
using AspNetMvc.Crm.Application.Services.Abstracts;
using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Crm.Domain.Repositories;
using AspNetMvc.Crm.EntityFramework;
using AutoMapper;

namespace AspNetMvc.Crm.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public List<CustomerDto> GetAllCustomers()
        {
            var entitylist = _customerRepository.GetAll();
            //var dtoList = new(); diyip list içinde foreach ile dönüp her elemanı birbirine eşitlemek ve dto'daki ek kolonları eklemek yerine
            //AutoMapper kütüphanesini kullanacağız.
            var dtoList = _mapper.Map<List<CustomerDto>>(entitylist);
            return dtoList;
        }

        public CustomerDto GetCustomerById(int id)
        {
            var entitiy = _customerRepository.GetById(id);
            var dto = _mapper.Map<CustomerDto>(entitiy);
            return dto;
        }

        public bool InsertCustomer(CreateOrUpdateCustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            return _customerRepository.Insert(customer);
        }

        public bool Update(CreateOrUpdateCustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            return _customerRepository.Update(customer);
        }

        public bool Delete(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            return (_customerRepository.Delete(customer));
        }

        public bool DeleteById(int id)
        {
            return _customerRepository.DeleteById(id);
        }

        public List<CustomerDto> GetAllByRegionId(int regionId)
        {
            var entityList = _customerRepository.GetAllByRegionId(regionId);
            var dtoList = _mapper.Map<List<CustomerDto>>(entityList);
            return dtoList;
        }




    }
}
