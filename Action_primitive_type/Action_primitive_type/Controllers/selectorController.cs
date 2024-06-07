using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Action_primitive_type.Controllers
{
    public class selectorController : Controller
    {
        // GET: selector
        [ActionName("cal")]
        public string calculatevalueusingautomata()
        {
            return "value calculated!!!";
        }
        [NonAction]
        public string sayhello2()
        {
            return "say hello 1 method called!!!";
        }
        [HttpGet]
        public string sayhello()
        {
            return "say hello 1 method called!!!";
        }

        public string sayhello(string id)
        {
            return "say hello 2 method called!!!";
        }
    }
}