using AspNetMvc.Framework.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Crm.Application.Dtos
{
    public class RequestDto : BaseDto
    {
        public int CustomerUserId { get; set; }

        public int EmployeeUserId { get; set; }

        public int RequestStatusId { get; set; }

        public string Description { get; set; }
    }
}
