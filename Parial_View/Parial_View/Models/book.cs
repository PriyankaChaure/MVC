using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parial_View.Models
{
    public class book
    {
        public Int64 bookid { get; set; }
        public string title { get; set; }
        public string author {  get; set; } 
        public string description { get; set; }
        public book() 
        {
            bookid = 1;
            title = "cvb";
            author = "ghggh" ;
            description = "jyguy ghfuy uyetetgru ytrreu";
        }
    }
}