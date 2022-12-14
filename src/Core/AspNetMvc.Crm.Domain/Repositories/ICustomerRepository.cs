using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Framework.Repository;

namespace AspNetMvc.Crm.Domain.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {

        public List<Customer> GetAllByRegionId(int regionId);
    }
}
