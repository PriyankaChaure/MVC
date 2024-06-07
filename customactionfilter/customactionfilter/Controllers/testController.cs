using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace customactionfilter.Controllers
{
   
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult about()
        {
            return View();
        }
        [AlogFilter]
        public ActionResult contact()
        {
            return View();
        }
    }
}