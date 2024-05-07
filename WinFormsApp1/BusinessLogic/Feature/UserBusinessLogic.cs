using DataAccess.DAO;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Feature
{
    public class UserBusinessLogic
    {
        
        public UserBusinessLogic() { }
        IUserDAO UserDAO = new UserDAO();

        public List<User> getAllUsers()
        {
            return UserDAO.GetAll();
        }

        public User getUser(int id)
        {
            return UserDAO.getUser(id);
        }

        public void addUser(User user)
        {
            UserDAO.addUser(user);
        }

        public void removeUser(int id)
        {
            UserDAO.removeUser(id);
        }

        public void updateUser(User user)
        {
            UserDAO.updateUser(user);
        }
    }
}
