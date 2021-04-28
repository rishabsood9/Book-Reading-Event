

using System.Collections.Generic;

namespace Shared
    {
    public class User
    {
        
        public string UserName { get; set; }
       
        public string EmailId { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        }
}
