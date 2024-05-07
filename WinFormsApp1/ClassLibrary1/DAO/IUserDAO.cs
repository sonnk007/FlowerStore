using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public interface IUserDAO 
    {
        List<User> GetAll();
        User getUser(int id);
        void addUser(User user);
        void removeUser(int id);
        void updateUser(User user);
    }
}
