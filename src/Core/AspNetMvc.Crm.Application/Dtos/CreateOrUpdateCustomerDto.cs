namespace AspNetMvc.Crm.Application.Dtos
{
    public class CreateOrUpdateCustomerDto
    {
        public int Id { get; set; }

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
