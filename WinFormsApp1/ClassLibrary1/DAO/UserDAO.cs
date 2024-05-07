using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class UserDAO : IUserDAO
    {
        private static UserDAO instance = null;
        private readonly FlowerShopContext _context = new FlowerShopContext();
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public UserDAO()
        {
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
        public User getUser(int id)
        {
            return _context.Users.SingleOrDefault(x => x.Uid == id);
        }

        public void addUser(User user)
        {
            if (user != null && !GetAll().Contains(user))
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }

        public void removeUser(int id)
        {
            User user = getUser(id);
            if (user != null)
            {
                _context.Remove(user);
            }
        }

        public void updateUser(User user) {
            if (user != null && getUser(user.Uid) != null)
            {
                _context.Users.Update(user);
                _context.SaveChanges();
            }
        }
    }
}
