using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace custom_authorization__filter.Models.UserVM
{
   
    public class signinclass
    {
        [EmailAddress(ErrorMessage ="email ")]
        [Required(ErrorMessage ="enter email id!!!")]
        public string emailid {  get; set; }
        [Required(ErrorMessage ="enter password!!!")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}