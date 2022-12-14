using AspNetMvc.Crm.Domain.Entities;

namespace AspNetMvc.Crm.Domain.Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAll();

        public Customer GetById(int id);

        public bool Insert(Customer customer);

        public bool Update(Customer customer);

        public bool Delete(Customer customer);

        public bool DeleteById(int id);

        public List<Customer> GetAllByRegionId(int regionId);
    }
}
