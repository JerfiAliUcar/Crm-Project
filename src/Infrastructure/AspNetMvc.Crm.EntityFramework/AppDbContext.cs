using Microsoft.EntityFrameworkCore;

namespace AspNetMvc.Crm.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        //Sql Server ve bağlantı metnini appsettings içerisinden alarak Program.cs içerisinde konfigüre ediyoruz.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //Eğer daha önce konfigüre edilmediyse burada konfigüre et (Program cs içinde konf. yapılmadıysa çalışır.)
            if (!builder.IsConfigured)
            {
                var connectionString = "Server=(localdb)\\MsSqlLocalDb;Database=CRM_Local;Trusted_Connection=True;";
                builder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
