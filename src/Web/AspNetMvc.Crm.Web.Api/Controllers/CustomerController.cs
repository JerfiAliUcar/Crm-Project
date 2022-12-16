using AspNetMvc.Crm.Application.Dtos;
using AspNetMvc.Crm.Application.Services.Abstracts;
using AspNetMvc.Crm.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Crm.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        //[HttpGet]
        //public List<Customer> Get()
        //{
        //    return _customerService.GetAllCustomers();
        //}

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var data = _customerService.GetCustomerById(id);

        //    return Ok(data);
        //}
    }
}
