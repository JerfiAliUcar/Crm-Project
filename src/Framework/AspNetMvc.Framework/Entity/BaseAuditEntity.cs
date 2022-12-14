namespace AspNetMvc.Framework.Entity
{
    public abstract class BaseAuditEntity : BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; }

        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }


    }


}
