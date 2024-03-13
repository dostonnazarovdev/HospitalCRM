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


    }
}
