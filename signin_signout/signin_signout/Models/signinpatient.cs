using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace signin_signout.Models
{
    [Table("tbl_signin")]
    public class signinpatient
    {
        [Required(ErrorMessage ="email id required!")]
        [EmailAddress(ErrorMessage ="enter valid email id!")]
        public string emailid {  get; set; }
        [Required(ErrorMessage = "password required!")]
        [DataType(DataType.Password)]
        public string password {  get; set; }
    }
}