using AspNetMvc.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Crm.Domain.Entities
{
    public class Request : BaseEntity, IEntity
    {
        public int CustomerUserId { get; set; }

        public int EmployeeUserId { get; set; }

        public int RequestStatusId { get; set; }

        public string Description { get; set; }


    }
}
