using ajax_ex_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajax_ex_.Controllers
{
    public class TestController : Controller
    {
        prachiEntities pr = new prachiEntities();
        // GET: Test
        public JsonResult getcustomer()
        {
            var v=this.pr.customertbls.ToList();
            return Json(v.ToList(),JsonRequestBehavior.AllowGet);
        }
        public ActionResult about()
        {
            return View();
        }
    }
}