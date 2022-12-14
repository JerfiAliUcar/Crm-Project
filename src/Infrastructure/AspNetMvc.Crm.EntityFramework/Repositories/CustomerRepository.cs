using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Crm.Domain.Repositories;
using AspNetMvc.Framework.Repository;

namespace AspNetMvc.Crm.EntityFramework.Repositories
{
    public class CustomerRepository : BaseRepository<Customer, AppDbContext>, ICustomerRepository
    {
        private readonly AppDbContext _db;

        public CustomerRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }


        public List<Customer> GetAllByRegionId(int regionId)
        {
            return _db.Customers.Where(e => e.RegionId == regionId).ToList();
        }



    }
}
