using AspNetMvc.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Crm.Domain.Entities
{
    public class User : BaseEntity, IEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }
    }
}
