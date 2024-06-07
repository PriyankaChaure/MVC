using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstex2.Models
{
    [Table("table_area")]
    public class area
    {
        [Key]
        public Int64 areaid { get; set; }
        public string areaname { get; set; }

        public virtual List<department> Departments { get; set; }
    }
}