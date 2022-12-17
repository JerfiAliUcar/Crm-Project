using AspNetMvc.Crm.Application.Dtos;
using AspNetMvc.Crm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Crm.Application.Services.Abstracts
{
    public interface IUserService
    {
        public List<User> GetAllUsers();

        public User GetUserById(int id);

        public bool InsertUser(User user);

        public bool Update(User user);

        public bool Delete(User user);

        public bool DeleteById(int id);
    }
}
