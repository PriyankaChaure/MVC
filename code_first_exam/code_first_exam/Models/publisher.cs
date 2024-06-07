using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace code_first_exam.Models
{
    [Table("tblpublisher")]
    public class publisher
    {
        [Key]
        public Int64 publisherid { get; set; }
        public string publishername { get; set; }
        public string address { get; set; }
        public string emailid { get; set; }
        public string mobileno { get; set; }

        public virtual List<book> books { get; set; }
    }
}