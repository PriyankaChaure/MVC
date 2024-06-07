using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomeActionFilters.Models;
using CustomeActionFilters.CustomFilters;


namespace CustomeActionFilters.Controllers
{
    [algofilter]
    public class TestController : Controller
    {
        chaureEntities ch = new chaureEntities();

        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();                
        }
        public ActionResult contact()
        {
            return View();
        }
    }
}