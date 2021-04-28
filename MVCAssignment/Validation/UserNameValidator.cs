
        
using System.ComponentModel.DataAnnotations;
using Shared;
using System.Collections.Generic;
using BL;
using System.Linq;
namespace MVCAssignment.Validation
        {
        public class UserNameValidator : ValidationAttribute
            {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
                {
                IEnumerable<User> users = new AllUsersBL().GetUsers;
                var property1 = validationContext.ObjectType.GetProperty("UserName");
                var property2 = validationContext.ObjectType.GetProperty("EmailId");
                string userName = (string)property1.GetValue(validationContext.ObjectInstance);
                string emailId = (string)property2.GetValue(validationContext.ObjectInstance);
                var queryUserName = (from u in users
                                     where u.UserName.Equals(userName, System.StringComparison.OrdinalIgnoreCase)
                                     select u).ToList().Count;
               

                
                    if (queryUserName != 0)
                        {
                        return new ValidationResult("" + validationContext.DisplayName + "already exists");
                        }
                    else
                        return ValidationResult.Success;
                 

                }
            }
        }
    
    