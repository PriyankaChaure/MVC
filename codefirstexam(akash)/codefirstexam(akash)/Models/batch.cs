using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstexam_akash_.Models
{
    [Table("tbl_batch")]
    public class batch
    {
        [Key]
        [Display(Name ="SrNo")]
        public Int64 batchid {  get; set; }
        public string batchtitle {  get; set; }
        [ForeignKey("trainer")]
        public Int64 trainerid { get; set; }
        public virtual trainer trainer { get; set; }
        [ForeignKey("course")]
        public Int64 courseid { get; set; }
        public virtual course course { get; set; }
        public DateTime startdate { get; set; }
        public Int64 noofstudent {  get; set; }

    }
}