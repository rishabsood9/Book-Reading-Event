using System.Linq;
namespace DAL
    {
    public class UserEmailDAL
        {
           public string GetUserEmail(string userName)
            {
           
                using (BookReadingContext context = new BookReadingContext())
                    {
                       string userEmail= (from u in context.Users
                                                         where u.UserName == userName
                                                         select u.EmailId).ToList().First();
                    return userEmail;

                    }
                
            }
           
        }
    }
