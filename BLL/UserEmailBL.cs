using DAL;

namespace BL
    {
   public class UserEmailBL
        {
            public string GetUserEmail(string userName)
            {
            
                return new UserEmailDAL().GetUserEmail(userName);
                
            }
        }
    }
