using System.Linq;
namespace DAL
    {
    public class UserRolesDAL
        {
           public string[] GetRoles(string userName)
            {
            using (BookReadingContext context = new BookReadingContext())
                {
                var result = (from user in context.Users
                              join role in context.Roles
                              on user.UserName equals role.UserId
                              where user.UserName == userName
                              select role.AssignedRole).ToArray();
                return result;       
                }
            }
        }
    }
