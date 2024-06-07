using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace customauthorizationfilter.Models
{
    [Table("userTbl")]
    public class user
    {
        [Key]
        public Int64 UserId { get; set; }   
        public string FirstName { get; set; }    
       public string LastName { get; set; } 
        public string EmailId {  get; set; }    
        public string MobileMo {  get; set; }   
        public string Address {  get; set; }    
        public string Password {  get; set; }   

    }
}