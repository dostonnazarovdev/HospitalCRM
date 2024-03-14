using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalCRM
{
    public class UserService
    {
        List<User> users = new List<User>();

     
        public bool Create(User user)
        {
            var existUser = users.FirstOrDefault(u => u.Id == user.Id);
            if (existUser != null)
            {
                users.Add(user);
                return true;
            }
            return false;
        }

        public User GetById(int id)
        {
            var user = users.FirstOrDefault(u=>u.Id==id);
            if (user != null)
            {
                return user;
            }
            return null;
        }

        public bool Update(User user)
        {
            var existUser = users.FirstOrDefault(x=>x.Id==user.Id);
            if (existUser != null)
            {
                existUser.FirstName = user.FirstName;
                existUser.LastName=user.LastName;
                existUser.PhoneNumber = user.PhoneNumber;
                existUser.Age = user.Age;
                existUser.DateOfBirth = user.DateOfBirth;
                existUser.Type = user.Type;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var user = users.FirstOrDefault(i => i.Id == id);
            if (user == null)
            {
                return false;
            }
            users.Remove(user);
            return true;
        }
   
        public List<User> GetAll()
        {
            return users;
        }
    }
}
