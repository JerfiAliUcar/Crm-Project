using AspNetMvc.Framework.Dtos;
using AspNetMvc.Framework.Entity;

namespace AspNetMvc.Crm.Application.Dtos.Customer
{
    public class CustomerDto : BaseDto
    {

        public int? UserId { get; set; }

        public int? GenderId { get; set; }

        public int? TitleId { get; set; }

        public string? CompanyName { get; set; }

        public string? TitleName { get; set; }

        public string? Gendername { get; set; }
    }

}
