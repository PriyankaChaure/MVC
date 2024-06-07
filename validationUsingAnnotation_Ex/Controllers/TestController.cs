using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using validationUsingAnnotation_Ex.Models;

namespace validationUsingAnnotation_Ex.Controllers
{
    public class TestController : Controller
    {
        prachiEntities1 pr=new prachiEntities1();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.pr.emptbls.ToList());
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(emptbl rec)
        {
            if(ModelState.IsValid) 
            {
                this.pr.emptbls.Add(rec);
                this.pr.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(rec);
        }
    }
}