using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using DAL;
namespace BL
    {
    public class UserValidationBL
        {
        UserValidationDAL userValidation = new UserValidationDAL();
         public bool UserExists(User user)
            {
            if (userValidation.UserExists(user))
                {
                if (userValidation.IsValid(user))
                    return true;
                else
                    return false;
                }
            else
                return false;
            }
         
        }
    }
