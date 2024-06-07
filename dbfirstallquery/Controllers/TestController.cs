using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbfirstallquery.Models;

namespace dbfirstallquery.Controllers
{
    public class TestController : Controller
    {
        prachiEntities priya=new prachiEntities();
        // GET: Test
        public ActionResult Index()
        {
            //var v = from t1 in this.priya.BillTbls
            //        join t2 in this.priya.customertbls
            //        on t1.customerid equals t2.customerid
            //        select new custbillVM
            //        {
            //            customerid =t2.customerid,
            //            customername =t2.customername,

            //             billid =t1.billid,
            //             billdate=t1.billdate,
            //             billamount=t1.billamount
            //        };

            //return View(v.ToList());
            var v = from t1 in this.priya.BillTbls
                    join t2 in this.priya.customertbls
                    on t1.customerid equals t2.customerid
                    join t3 in this.priya.paymenttbls
                    on t1.billid equals t3.billid
                    where t3.paymenetamount>10000
                    select new custbillVM
                    {
                        customerid=t1.customerid,
                        customername=t2.customername,
                        billid=t1.billid,
                        billamount=t1.billid,
                        billdate=t1.billdate,   
                        paymenetamount=t3.paymenetamount,
                        paymentdate=t3.paymentdate

                    };
                    return View(v.ToList());
        }
        public ActionResult showjoins()
        {
            //inner join
            //var v = from t1 in this.priya.atables
            //        join t2 in this.priya.btables
            //        on t1.aid equals t2.aid
            //        select new abclassVM
            //        {
            //            aid = t1.aid,
            //            avalue = t1.avalue,
            //            bid = t2.bid,
            //            bvalue = t2.bvalue,

            //        };
            //return View(v.ToList());


            //left outer join

            var left = from t1 in this.priya.atables
                       join t2 in this.priya.btables
                       on t1.aid equals t2.aid
                       into g
                       from t2 in g.DefaultIfEmpty()
                       select new abclassVM
                       {
                           aid = t1.aid,
                           avalue = t1.avalue,
                           bid = t2.bid,
                           bvalue = t2.bvalue,

                       };


            //return View(left.ToList());


            var right = from t1 in this.priya.btables
                       join t2 in this.priya.atables
                       on t1.aid equals t2.aid
                       into g
                       from t2 in g.DefaultIfEmpty()
                       select new abclassVM
                       {
                           aid = t2.aid,
                           avalue = t2.avalue,
                           bid = t1.bid,
                           bvalue = t1.bvalue,

                       };
           // return View(right.ToList());

            var v = right.Union(left);
            //return View(v.ToList());

            var v1 = right.Intersect(left);
            return View(v1.ToList());
        }
    }
}