
using System.ComponentModel.DataAnnotations;
using Shared;
using System.Collections.Generic;
using BL;
using System.Linq;
namespace MVCAssignment.Validation
    {
    public class UserEmailValidator:ValidationAttribute
        {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
            IEnumerable<User> users = new AllUsersBL().GetUsers;
            var property1 = validationContext.ObjectType.GetProperty("UserName");
            var property2= validationContext.ObjectType.GetProperty("EmailId");
            string userName = (string)property1.GetValue(validationContext.ObjectInstance);
            string emailId=(string)property2.GetValue(validationContext.ObjectInstance);
            
            var queryEmailId = (from u in users
                               where u.EmailId.Equals(emailId,System.StringComparison.OrdinalIgnoreCase)
                               select u).ToList().Count;


            if (queryEmailId==0)
                {
                
                    return ValidationResult.Success;
                }
            else
                return new ValidationResult("" + validationContext.DisplayName + " already exists");

            }
        }
    }