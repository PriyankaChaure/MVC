using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Actionfilter_authorize_allowanonymous.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
       // [Authorize]
        public ActionResult About()
        {
            return View();
        }
       // [Authorize]
        public ActionResult Contact()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult services()
        {
            return View();
        }

    }
}