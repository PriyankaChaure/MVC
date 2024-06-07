using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_on_codefirst.Models
{
    [Table("table_city1")]
    public class city1
    {
        [Key]
        public Int64 cityid { get; set; }
        public string cityname { get; set; }
        public virtual List<emp1> emp1s { get; set; }

    }
}