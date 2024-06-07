using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstforpractice.Models
{
    [Table("tblteam")]
    public class team
    {
        [Key]
        public Int64 teamid { get; set; }
        public string teamname {  get; set; }

        [ForeignKey("country")]
        public Int64 countryid { get; set; }
        public virtual country country { get; set; }
        public virtual List<player> player { get; set; }

    }
}