using AspNetMvc.Crm.Application.Dtos.Customer;
using AspNetMvc.Crm.Application.Dtos.Employee;
using AspNetMvc.Crm.Application.Services.Abstracts;
using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Crm.Domain.Repositories;
using AspNetMvc.Crm.EntityFramework;
using AutoMapper;

namespace AspNetMvc.Crm.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public List<EmployeeDto> GetAllEmployees()
        {
            var entitylist = _employeeRepository.GetAll();
            //var dtoList = new(); diyip list içinde foreach ile dönüp her elemanı birbirine eşitlemek ve dto'daki ek kolonları eklemek yerine
            //AutoMapper kütüphanesini kullanacağız.
            var dtoList = _mapper.Map<List<EmployeeDto>>(entitylist);
            return dtoList;
        }

        public EmployeeDto GetEmployeeById(int id)
        {
            var entitiy = _employeeRepository.GetById(id);
            var dto = _mapper.Map<EmployeeDto>(entitiy);
            return dto;
        }

        public bool InsertCustomer(CreateOrUpdateEmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            return _employeeRepository.Insert(employee);
        }

        public bool Update(CreateOrUpdateEmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            return _employeeRepository.Update(employee);
        }

        public bool Delete(EmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            return (_employeeRepository.Delete(employee));
        }

        public bool DeleteById(int id)
        {
            return _employeeRepository.DeleteById(id);
        }

        public List<EmployeeDto> GetAllByRegionId(int regionId)
        {
            var entityList = _employeeRepository.GetAllByRegionId(regionId);
            var dtoList = _mapper.Map<List<EmployeeDto>>(entityList);
            return dtoList;
        }

        public bool InsertEmployee(CreateOrUpdateEmployeeDto employee)
        {
            throw new NotImplementedException();
        }
    }
}
