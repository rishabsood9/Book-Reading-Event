using MVCAssignment.Validation;
using System.ComponentModel.DataAnnotations;
namespace MVCAssignment.Models
    {
    public class RegisterUserModel
        {
        [Required]
        
        [UserNameValidator]
        public string UserName { get; set; }

        [Required]
        [UserEmailValidator]
        [EmailAddress]
        public string EmailId { get; set; }

        [Required]
        [MinLength(5)]
        public string Password { get; set; }
        }
    }