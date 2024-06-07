using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace code_first_exam.Models
{
    [Table("tblbook")]
    public class book
    {
        [Key]
        public Int64 bookid {  get; set; }
        public string bookname { get; set; }
        public string bookdescription { get; set; }

        [ForeignKey("category")]
        public Int64 bookcatid { get; set; }
        public virtual bookcategory category { get; set; }

        [ForeignKey("author")]
        public Int64 authorid { get; set; }
        public virtual author author { get; set; }

       
        public Int64 publisherid { get; set; }
        public virtual publisher publisher { get;}

        public decimal price { get; set; }

    }
}