using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Crm.Domain.Repositories;

namespace AspNetMvc.Crm.EntityFramework.Repositories
{
    public class EmployeerRepository : IEmployeeRepository
    {
        private readonly AppDbContext _db;

        public EmployeerRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Employee> GetAll()
        {
            return _db.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            return _db.Employees.FirstOrDefault(e => e.Id == id);
        }

        public bool Insert(Employee employee)
        {
            _db.Employees.Add(employee);
            int affected = _db.SaveChanges();

            return affected > 0;
        }

        public bool Update(Employee employee)
        {
            _db.Employees.Update(employee);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool Delete(Employee employee)
        {
            _db.Employees.Remove(employee);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool DeleteById(int id)
        {
            var employee = _db.Employees.Find(id);
            _db.Employees.Remove(employee);
            int affected = _db.SaveChanges();
            return affected > 0;

        }

        public List<Employee> GetAllByRegionId(int regionId)
        {
            return _db.Employees.Where(e => e.RegionId == regionId).ToList();
        }



    }
}
