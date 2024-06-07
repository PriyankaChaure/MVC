using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilters_result_response_outputcache.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [OutputCache(Duration =10)]
        public string gettime()
        {
            return DateTime.Now.ToString();
        }
    }
}