using AspNetMvc.Crm.Domain.Repositories;
using AspNetMvc.Crm.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetMvc.Crm.EntityFramework
{
    public static class ServiceRegistrations
    {
        public static void AddEntityFrameworkRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Default");
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            //Konfigurasyonu DbContext OnConfiguring içerisinde yapılabilir
            //services.AddDbContext<AppDbContext>();

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IRequestRepository, RequestRepository>();
            services.AddTransient<IUserRepository, UserRepository>();


        }
    }
}
