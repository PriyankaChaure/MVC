using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbfirstex.Models;

namespace dbfirstex.Controllers
{
    public class TestController : Controller
    {
        prachiEntities priyanka = new prachiEntities();

        // GET: Test
        public ActionResult Index()
        {

            //var v = from t in priyanka.emptbls
            //        where t.salary >= 15000
            //        select t;
            //return View(v.ToList());
            return View(priyanka.emptbls.ToList());
        }
        public ActionResult Depttable()
        {
            return View(priyanka.customertbls.ToList());
        }
    }
}