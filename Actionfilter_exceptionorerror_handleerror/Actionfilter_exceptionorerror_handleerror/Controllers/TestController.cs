using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Actionfilter_exceptionorerror_handleerror.Controllers
{
    [HandleError(View ="_customerror")]
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public int dodivision(int a,int b)
        {
            return a / b;
        }
    }
}