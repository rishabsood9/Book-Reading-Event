using System;
using System.ComponentModel.DataAnnotations;

namespace MVCAssignment.Models
    {
    public class CommentModel
        {
        
        [Required]
        public string CommentAdded { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        
        [Required]
        public int EventId { get; set; }
        }
    }