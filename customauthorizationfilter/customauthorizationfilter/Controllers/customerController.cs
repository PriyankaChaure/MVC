using customauthorizationfilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace customauthorizationfilter.Controllers
{
    public class customerController : Controller
    {
        UserContext a=new UserContext();    
        // GET: customer
        public ActionResult Index()
        {
            return View(this.a.customers.ToList());
        }
    }
}