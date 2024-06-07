using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace code_first_exam.Models
{
    [Table("tblbookcategory")]
    public class bookcategory
    {
        [Key]
        public Int64 bookcatid {  get; set; }
        public string bookcatname {  get; set; }

        public virtual List<book> books { get; set; }
    }
}