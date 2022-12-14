using AspNetMvc.Crm.Application.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Crm.Web.Mvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            var customers = _customerService.GetAllCustomers();
            return View(customers);
        }
    }
}
