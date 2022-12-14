using AspNetMvc.Crm.Domain.Entities;

namespace AspNetMvc.Crm.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAll();

        public Employee GetById(int id);

        public bool Insert(Employee employee);

        public bool Update(Employee employee);

        public bool Delete(Employee employee);

        public bool DeleteById(int id);

        public List<Employee> GetAllByRegionId(int regionId);
    }
}
