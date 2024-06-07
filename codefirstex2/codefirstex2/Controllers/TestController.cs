using codefirstex2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codefirstex2.Controllers
{
    public class TestController : Controller
    {
        CompanyContext cntx=new CompanyContext();
        // GET: Test
        public ActionResult Index()
        {
            return View(cntx.employees.ToList());
        }
    }
}