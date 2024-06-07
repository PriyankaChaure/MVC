using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace validationUsingAnnotation_Ex.Models
{
    [MetadataType(typeof(class1))]
    public partial class emptbl
    {

    }
    public class class1
    {

        [Required(ErrorMessage = "Please Enter Name!!")]
        public string empname { get; set; }
        [Display(Name = "current Address")]
        [Required(ErrorMessage = "Please Enter current Address!!")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="minimum 5 maximum 20 character")]
        public string address { get; set; }
        [Required(ErrorMessage = "Please Enter valid EmailId!!")]
        [EmailAddress(ErrorMessage ="invalid email id")]
        public string emailid { get; set; }
        [Required(ErrorMessage = "Please Enter MobileNo!!")]
        [RegularExpression(@"^\d{10}$")]
        public string mono { get; set; }
        [Required(ErrorMessage = "Please Enter salary!!")]
        [Range(10000,90000,ErrorMessage ="salary out of range between(10000-90000)")]
        public decimal salary { get; set; }
        [Required(ErrorMessage = "Please Enter deptid!!")]
        public long dept { get; set; }
    }
}