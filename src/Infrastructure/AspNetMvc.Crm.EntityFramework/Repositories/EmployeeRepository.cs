using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Crm.Domain.Repositories;
using AspNetMvc.Framework.Repository;

namespace AspNetMvc.Crm.EntityFramework.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee, AppDbContext>, IEmployeeRepository
    {
        private readonly AppDbContext _db;

        public EmployeeRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
        
        public List<Employee> GetAllByRegionId(int regionId)
        {
            return _db.Employees.Where(e => e.RegionId == regionId).ToList();
        }



    }
}
