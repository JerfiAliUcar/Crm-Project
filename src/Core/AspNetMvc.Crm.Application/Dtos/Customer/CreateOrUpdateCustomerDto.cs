﻿using AspNetMvc.Framework.Dtos;

namespace AspNetMvc.Crm.Application.Dtos.Customer
{
    public class CreateOrUpdateCustomerDto : BaseDto
    {

        public int? UserId { get; set; }

        public string? IdentityNumber { get; set; }

        public int? GenderId { get; set; }

        public int? StatusTypeId { get; set; }

        public int? TitleId { get; set; }

        public string? CompanyName { get; set; }

        public int? RegionId { get; set; }

        public DateTime? BirthDate { get; set; }

    }

}
