using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstforpractice.Models
{
    [Table("tblsportseries")]
    public class sportseries
    {
        [Key]
        public Int64 sportseriesid { get; set; }
        public string soprtseriesname { get; set; }
        public virtual List<player> players { get; set; }
        
    }
}