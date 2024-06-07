using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace customauthorizationfilter.Models
{
    [Table("CustomerTbl")]
    public class customer
    {
        [Key]
        public Int64 customerId {  get; set; }  
        public string customerName { get; set; }    
        public string Address {  get; set; } 
        public string EmailId {  get; set; }    
        public string MobileNo {  get; set; }   
        public decimal creditLimit {  get; set; }   

    }
}