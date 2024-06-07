using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstexam_akash_.Models
{
    [Table("tbl_trainer")]
    public class trainer
    {
        [Key]
        public Int64 trainerid {  get; set; }   
        public string trainername {  get; set; }
        public virtual List<batch>batches { get; set; }
    }
}