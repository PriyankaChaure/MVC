using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace view_example.Controllers
{
    public class ABCDController : Controller
    {
        // GET: ABCD
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
    }
}