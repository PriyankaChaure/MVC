using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstex2.Models
{
    [Table("table_employee")]
    public class employee
    {
        [Key]
        public Int64 empid { get; set; }
        public string empname { get; set; }
        public string address { get; set; }
        public string mobileno { get; set; }    
        public decimal salary { get; set; }
        public DateTime joindate { get; set; }
       
        [ForeignKey("department")]
        public Int64 deptid {  get; set; }

        public virtual department department { get; set; }

    }
}