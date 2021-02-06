using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HrProject_Models
{
    public class PostCreate
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least 1 character.")]
        [MaxLength(160, ErrorMessage = "There are too many characters in this field.")]
        public string Text { get; set; }
    }
}
