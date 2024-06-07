using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codefirstforpractice.Models
{
    public class classofVM
    {
        public Int64 countryid { get; set; }
        public string countryname { get; set; }
        public Int64 teamid { get; set; }
        public string teamname { get; set; }
        public Int64 sportseriesid { get; set; }
        public string soprtseriesname { get; set; }
        public Int64 playerid { get; set; }
        public string playername { get; set; }

        public decimal scoreplayer { get; set; }
    }
}