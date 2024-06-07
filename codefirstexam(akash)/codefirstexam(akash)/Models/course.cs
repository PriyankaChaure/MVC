using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstexam_akash_.Models
{
    [Table("tbl_course")]
    public class course
    {
        [Key]
        public Int64 courseid {  get; set; }
        public string coursename {  get; set; }
        public decimal duration {  get; set; }
        public decimal fees {  get; set; }

        [ForeignKey("coursecategories")]
        public Int64 coursecatid { get; set; }
        public virtual coursecategory coursecategories { get; set; }
        public virtual List<batch> batches { get; set; }
    }
}