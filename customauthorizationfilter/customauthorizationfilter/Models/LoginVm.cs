using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace customauthorizationfilter.Models
{
    public class LoginVm
    {
        [Required(ErrorMessage ="EmailId Required")]
        [EmailAddress (ErrorMessage ="invalid Email Id")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "password Required")]
        [DataType (DataType.Password)]
        public string Password { get; set; }    
    }
}