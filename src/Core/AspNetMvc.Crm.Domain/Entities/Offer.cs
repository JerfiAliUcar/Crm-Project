using AspNetMvc.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Crm.Domain.Entities
{
    public class Offer : BaseEntity, IEntity
    {
        public int RequestId { get; set; }

        public int EmployeeUserId { get; set; }

        public DateTime OfferDate { get; set; }

        public int BidAmount { get; set; }

    }
}
