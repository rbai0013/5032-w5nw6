using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MyFirstModelView.Models
{
    public class FormModel
    {
    }

    public class FormOneViewModel 
    { 
        [Required(ErrorMessage = "First name is required!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Minium length of 5 characters")]
        [Display(Name = "First Name")] 
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Minium length of 5 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } 
    }
}