using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace signin_signout.Models
{
    [Table("tbl_doctor")]
    public class doctor
    {
        [Key]
        [Display(Name ="Sr.No")]
        public Int64 doctorid{get; set;}
        public string doctorname { get; set;}
        public string qualification {  get; set;}
        public string specialist {  get; set;}
        public string emilid {  get; set;}
        public  string phoneno {  get; set;}
        public string password {  get; set;}
        
    }
}