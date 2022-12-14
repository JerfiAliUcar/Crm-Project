using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Framework.Repository;

namespace AspNetMvc.Crm.Domain.Repositories
{
    //IRepository içine generic olarak Customer verildi.
    //<TEntity> yerine <Employee> gönderildi.
    public interface IEmployeeRepository : IRepository<Employee>
    {
        
        public List<Employee> GetAllByRegionId(int regionId);
    }
}
