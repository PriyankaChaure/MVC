using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace signin_signout.Models
{
    [Table("tbl_patient")]
    public class patient
    {
        [Key]
        public Int64 patientid {  get; set; }
        public string patientname {  get; set; }
        public Int64 age {  get; set; }
        public DateTime appoinmentdate { get; set; }
        public string emailid {  get; set; }
        public string phoneno {  get; set; }
        public string disease {  get; set; }
        public string address {  get; set; }
        public string password {  get; set; }
        
    }
}