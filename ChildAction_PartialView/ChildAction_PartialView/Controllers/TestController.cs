using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChildAction_PartialView.Controllers
{
   
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult getpartial()
        {
            return PartialView("_Demo");
        }
    }
}