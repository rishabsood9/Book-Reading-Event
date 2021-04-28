using Shared;
using DAL;
using System.Collections.Generic;
using System.Linq;
namespace BL
    {
   public  class RegisterUserBL
        {
           public bool AddUser(User user)
            {
            IEnumerable<User> users = new AllUsersDAL().GetUsers;
            int count = (from u in users
                        where (u.EmailId == user.EmailId) || (u.UserName == user.UserName)
                        select u).ToList().Count();
            if (count==0)
                {
                new RegisterUserDAL().AddUser(user);
                return true;
                }
            else
                {
                return false;
                }
            }
        }
    }
