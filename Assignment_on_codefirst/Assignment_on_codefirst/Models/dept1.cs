using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_on_codefirst.Models
{
    [Table("table_dept1")]
    public class dept1
    {
        [Key]
        public Int64 deptid { get; set; }
        public string deptName { get; set;}
        public virtual List<emp1> emp1s { get; set; }
    }
}