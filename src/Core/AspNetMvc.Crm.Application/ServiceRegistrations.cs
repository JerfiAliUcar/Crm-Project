using AspNetMvc.Crm.Application.Dtos;
using AspNetMvc.Crm.Application.Mappings;
using AspNetMvc.Crm.Application.Services;
using AspNetMvc.Crm.Application.Services.Abstracts;
using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Crm.Domain.Repositories;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AspNetMvc.Crm.Application
{
    public static class ServiceRegistrations
    {
        //Application altındaki Service registration. Burada application ile ilgili olanları koyacağız
        public static void AddApplicationRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IRequestService, RequestService>();
            services.AddTransient<IUserService, UserService>();

            //AutoMapper Konfigürasyonu burada yapacağız. Bu kod ile MappingProfile'ı ayarlıyoruz.
            //services.AddAutoMapper(typeof(MappingProfile));

            var assembly = Assembly.GetExecutingAssembly();
           
            //Crm.Application altında gördüğün tümProfile sınıflarını otomatik ayarlar:  
            services.AddAutoMapper(assembly);
        }
    }
}
