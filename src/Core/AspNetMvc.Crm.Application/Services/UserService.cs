using AspNetMvc.Crm.Application.Services.Abstracts;
using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Crm.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Crm.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public List<User> GetAllUsers()
        {
            var userList = _userRepository.GetAll();
            return userList;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }
         
        public bool InsertUser(User user)
        {
            return _userRepository.Insert(user);
        }
        
        public bool Delete(User user)
        {
            return _userRepository.Delete(user);
        }

        public bool DeleteById(int id)
        {
            return _userRepository.DeleteById(id);
        }
       

        public bool Update(User user)
        {
            return _userRepository.Update(user);
        }
    }
}
