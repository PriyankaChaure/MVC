using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace view_example.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ViewResult Index()
        {
            return View();
        }
        public ActionResult about()
        {
            return View("demo");
        }
        public ActionResult getcommmon()
        {
            return View("index");
        }
    }
}