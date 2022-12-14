using AspNetMvc.Crm.Application.Dtos;
using AspNetMvc.Crm.Domain.Entities;

namespace AspNetMvc.Crm.Application.Services.Abstracts
{
    public interface ICustomerService
    {
        public List<CustomerDto> GetAllCustomers();
       
        public CustomerDto GetCustomerById(int id);
        
        public bool InsertCustomer(CreateOrUpdateCustomerDto customer);
        
        public bool Update(CreateOrUpdateCustomerDto customer);
        
        public bool Delete(CustomerDto customer);
        
        public bool DeleteById(int id);

        public List<CustomerDto> GetAllByRegionId(int regionId);
    }
}
