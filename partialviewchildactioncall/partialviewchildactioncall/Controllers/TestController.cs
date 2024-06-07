using partialviewchildactioncall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace partialviewchildactioncall.Controllers
{
    public class TestController : Controller
    {
        prachiEntities pr = new prachiEntities();
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult getemp()
        {
            var v = this.pr.emptbls.OrderByDescending(p => p.salary).Take(5); 
            return PartialView("_partialView",v.ToList());
        }
        public PartialViewResult getcust()
        {
            var v = this.pr.customertbls.FirstOrDefault();
            return PartialView("_CustView",v);
        }
        public PartialViewResult getstud()
        {
            var v = this.pr.students.ToList().Last();
            return PartialView("_studentView",v);
        }

        public PartialViewResult getdept()
        {
            var v = this.pr.depttbls.ToList();
            return PartialView("_department", v);
        }
    }
}