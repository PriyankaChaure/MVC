using custom_authorization__filter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using custom_authorization__filter.Custom_Filter;

namespace custom_authorization__filter.Controllers
{
    [user_authorization]
    public class TestController : Controller
    {
        chaureEntities ch = new chaureEntities();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.ch.products.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(product rec)
        {
            if(ModelState.IsValid)
            {
                this.ch.products.Add(rec);
                this.ch.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }
    }
}