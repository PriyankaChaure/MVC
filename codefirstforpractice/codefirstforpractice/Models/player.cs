using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstforpractice.Models
{
    [Table("tblplayer")]
    public class player
    {
        [Key]
        public Int64 playerid {  get; set; }
        public string playername {  get; set; }

        public decimal scoreplayer {  get; set; }

        [ForeignKey("sportseries")]
        public Int64 sportseriesid { get; set; }
        public virtual sportseries sportseries { get; set; }

        [ForeignKey("team")]
        public Int64 teamid { get; set; }
        public virtual team team { get; set; }

    }
}