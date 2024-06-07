using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codefirstforpractice.Models
{
    [Table("tblcountry")]
    public class country
    {
        [Key]
        public Int64 countryid { get; set; }
        public string countryname { get; set; }
        public virtual List<team>teams { get; set; }
    }
}