using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using validation_ex.Models;

namespace validation_ex.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer rec)
        {
            if (ModelState.IsValid)
            {
                if (rec.CreditLimit%2!=0)
                {
                    ModelState.AddModelError("CreditLimit", "credit limit should be even!!!");
                    return View(rec);
                }
                else
                {
                    return View(rec);
                }
            }
            else
            {
                return View(rec);
            }
        }
    }
}