using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Crm.Domain.Repositories;

namespace AspNetMvc.Crm.EntityFramework.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _db;

        public CustomerRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Customer> GetAll()
        {
            return _db.Customers.ToList();
        }

        public Customer? GetById(int id)
        {
            return _db.Customers.FirstOrDefault(e => e.Id == id);
        }

        public bool Insert(Customer customer)
        {
            _db.Customers.Add(customer);
            int affected = _db.SaveChanges();

            return affected > 0;
        }

        public bool Update(Customer customer)
        {
            _db.Customers.Update(customer);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool Delete(Customer customer)
        {
            _db.Customers.Remove(customer);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool DeleteById(int id)
        {
            var customer = _db.Customers.Find(id);
            _db.Customers.Remove(customer);
            int affected = _db.SaveChanges();
            return affected > 0;

        }

        public List<Customer> GetAllByRegionId(int regionId)
        {
            return _db.Customers.Where(e => e.RegionId == regionId).ToList();
        }



    }
}
