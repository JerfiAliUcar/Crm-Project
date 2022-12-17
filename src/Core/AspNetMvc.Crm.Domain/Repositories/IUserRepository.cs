using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Crm.Domain.Repositories
{
    public interface IUserRepository:IRepository<User>
    {
        
    }
}
