using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Child_Action_Calls.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public string sayhello()
        {
            return "say hello called!!";
        }
        public string saybye()
        {
            return "say bye called!!";
        }
    }
}