using Antiforgery_Token.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Antiforgery_Token.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult create()
        { 
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult create(product p)
        {
            if (ModelState.IsValid)
            {
                //save code
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}