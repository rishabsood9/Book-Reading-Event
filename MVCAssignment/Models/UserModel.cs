using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
    {
    public class UserModel
        {
           [Required]
           public string UserName { get; set; }
           [Required]
           public string Password { get; set; }
        }
    }