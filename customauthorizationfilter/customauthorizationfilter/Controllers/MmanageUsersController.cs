using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace customauthorizationfilter.Controllers
{
    public class MmanageUsersController : Controller
    {
        [HttpGet]
        // GET: MmanageUsers
        public ActionResult Login()
        {
            return View();
        }
      
        
    }
}