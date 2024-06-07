using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_on_codefirst.Models
{
    [Table("table_emp1")]
    public class emp1
    {
        [Key]
        public Int64 empid {  get; set; }
        public string empname { get; set; }
        public string address { get; set; }
        public string mobileno { get; set; }
        public decimal salary {  get; set; }
      
        public Int64 deptid {  get; set; }
        
        public Int64 cityid { get; set; }
        public virtual dept1 dept1s { get; set; }
        public virtual city1 city1s { get; set; }
    }
}