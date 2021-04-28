using DAL;
namespace BL
    {
    public class UserRolesBL
        {
        public string[] GetRoles(string userName)
            {
            return new UserRolesDAL().GetRoles(userName);
            }
        }
    }
