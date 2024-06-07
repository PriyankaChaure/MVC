using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Antiforgery_Token.Models
{
    public class product
    {
        public Int64 productid {  get; set; }
        public string productname { get; set; }
        public string mfgname { get; set; }
        public string productdescription { get; set; }
    }
}