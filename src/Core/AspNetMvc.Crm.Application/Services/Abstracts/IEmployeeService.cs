using AspNetMvc.Crm.Application.Dtos.Customer;
using AspNetMvc.Crm.Application.Dtos.Employee;
using AspNetMvc.Crm.Domain.Entities;

namespace AspNetMvc.Crm.Application.Services.Abstracts
{
    public interface IEmployeeService
    {
        public List<EmployeeDto> GetAllEmployees();
       
        public EmployeeDto GetEmployeeById(int id);
        
        public bool InsertEmployee(CreateOrUpdateEmployeeDto employee);
        
        public bool Update(CreateOrUpdateEmployeeDto employee);
        
        public bool Delete(EmployeeDto employee);
        
        public bool DeleteById(int id);

        public List<EmployeeDto> GetAllByRegionId(int regionId);
    }
}
