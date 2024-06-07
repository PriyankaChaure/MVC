using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace validation_ex.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="Please Enter Name!!")]
        public Int64 CustomerId { get; set; }
        [StringLength(15,MinimumLength =5, ErrorMessage ="Name Range Between[5-15]")]
        public string CustomerName { get; set; }
        [Display(Name="current Address")]
        public string Address {  get; set; }
        [EmailAddress(ErrorMessage ="Plaese Enter Email-Id")]
        public string EmailId {  get; set; }
        [RegularExpression(@"^\d{10}$")]
        public string PhoneNumber { get; set; }
        [Range(1000,10000,ErrorMessage ="Enter Credit Limit In The Randge Of[1000-10000] ")]
        public decimal CreditLimit {  get; set; }
        [Required(ErrorMessage ="Please Enter Password!!!")]
        [DataType(DataType.Password)]
        public string Password {  get; set; }
        [Required(ErrorMessage = "Please Enter Confirm Password!!!")]
        [Compare("Password",ErrorMessage ="Password & Confirm Password Should Not Match!!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword {  get; set; }
    }
}