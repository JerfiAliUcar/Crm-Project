using AspNetMvc.Crm.Application.Dtos;
using AspNetMvc.Crm.Application.Dtos.Customer;
using AspNetMvc.Crm.Application.Dtos.Employee;
using AspNetMvc.Crm.Application.Services.Abstracts;
using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Crm.Domain.Repositories;
using AspNetMvc.Crm.EntityFramework;
using AspNetMvc.Crm.EntityFramework.Repositories;
using AutoMapper;

namespace AspNetMvc.Crm.Application.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IMapper _mapper;

        public RequestService(IRequestRepository requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public List<RequestDto> GetAllRequests()
        {
            var entitylist = _requestRepository.GetAll();
            //var dtoList = new(); diyip list içinde foreach ile dönüp her elemanı birbirine eşitlemek ve dto'daki ek kolonları eklemek yerine
            //AutoMapper kütüphanesini kullanacağız.
            var dtoList = _mapper.Map<List<RequestDto>>(entitylist);
            return dtoList;
        }
        
        public RequestDto GetRequestById(int id)
        {
            var entity = _requestRepository.GetById(id);
            var dto = _mapper.Map<RequestDto>(entity);
            return dto;
        }

        public bool InsertRequest(RequestDto requestDto)
        {
            var request = _mapper.Map<Request>(requestDto);
            return _requestRepository.Insert(request);
        }

        public bool Update(RequestDto requestDto)
        {
            var request = _mapper.Map<Request>(requestDto);
            return _requestRepository.Update(request);
        }

        public bool Delete(RequestDto requestDto)
        {
            var request = _mapper.Map<Request>(requestDto);
            return (_requestRepository.Delete(request));
        }

        public bool DeleteById(int id)
        {
            return _requestRepository.DeleteById(id);
        }
        
    }
}
