using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Your name: ")]
        public string NameField {get; set;}

        [Required]
        [Display(Name = "Dojo location: ")]
        public string DojoField {get; set;}

        [Required]
        [Display(Name = "Favorite language: ")]
        public string LanguageField {get; set;}

        [MinLength(20)]
        [Display(Name = "Comment (Optional): ")]
        public string CommentField {get; set;}
    }
}