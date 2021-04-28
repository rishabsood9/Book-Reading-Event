using Shared;
namespace DAL
    {
    public class RegisterUserDAL
        {
            public void AddUser(User user)
            {
            using (BookReadingContext context = new BookReadingContext())
                {
                context.Users.Add(user);
                context.SaveChanges();
                Role role = new Role();
                role.User = user;
                role.AssignedRole = "User";
                context.Roles.Add(role);
               

                context.SaveChanges();
                }
            }
        }
    }
