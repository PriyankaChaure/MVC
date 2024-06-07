using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace code_first_exam.Models
{
    [Table("tblauthor")]
    public class author
    {
        [Key]
        public Int64 authorid {  get; set; }    
        public string authorname {  get; set; }

        public virtual List<book> books { get; set; }
    }
}