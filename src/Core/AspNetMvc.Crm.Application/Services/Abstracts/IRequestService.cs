using AspNetMvc.Crm.Application.Dtos;
using AspNetMvc.Crm.Application.Dtos.Customer;
using AspNetMvc.Crm.Application.Dtos.Employee;
using AspNetMvc.Crm.Domain.Entities;

namespace AspNetMvc.Crm.Application.Services.Abstracts
{
    public interface IRequestService
    {
        public List<RequestDto> GetAllRequests();

        public RequestDto GetRequestById(int id);

        public bool InsertRequest(RequestDto request);

        public bool Update(RequestDto request);

        public bool Delete(RequestDto request);

        public bool DeleteById(int id);

    }
}
