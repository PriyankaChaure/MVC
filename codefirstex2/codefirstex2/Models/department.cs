using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstex2.Models
{
    [Table("table_department")]
    public class department
    {
        [Key]
        public Int64 deptid { get; set; }
        public string deptname { get; set; }
        [ForeignKey("area")]
        public Int64 areaid { get; set; }

        public virtual List<employee> employees { get; set; } 
       
        public virtual area area { get; set; }

    }
}