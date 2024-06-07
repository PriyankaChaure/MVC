using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dbfirstallquery.Models
{
    public class custbillVM
    {
        public long? customerid { get; set; }
        public string customername { get; set; }
        public long? billid { get; set; }
        public DateTime? billdate { get; set; }
        public decimal? billamount { get; set; }
        public DateTime? paymentdate { get; set; }
        public decimal? paymenetamount { get; set; }


    }
}