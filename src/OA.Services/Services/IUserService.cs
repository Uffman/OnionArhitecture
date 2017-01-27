using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OA.Data.Entities;

namespace OA.Services.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);
    }
}
