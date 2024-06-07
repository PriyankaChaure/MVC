using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstexam_akash_.Models
{
    [Table("tbl_coursecategory")]
    public class coursecategory
    {
        [Key]
        public Int64 coursecatid {  get; set; }
        public string coursecatname { get; set; }

        public virtual List<course>courses { get; set; }
    }
}