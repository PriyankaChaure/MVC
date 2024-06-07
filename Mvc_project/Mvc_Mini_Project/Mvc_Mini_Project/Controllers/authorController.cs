using Mvc_Mini_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Mini_Project.Authentication;

namespace Mvc_Mini_Project.Controllers
{
    //[UserAuthentication]
    public class authorController : Controller
    {
        miniprocontext mnc = new miniprocontext();
        // GET: author
        public ActionResult Index()
        {
            return View(this.mnc.authors.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(author rec)
        {
            this.mnc.authors.Add(rec);
            this.mnc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.mnc.authors.SingleOrDefault(p => p.AuthorId == id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(author rec)
        {
            this.mnc.Entry(rec).State = System.Data.Entity.EntityState.Modified;
            this.mnc.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.mnc.authors.Find(id);

            this.mnc.authors.Remove(rec);
            this.mnc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(Int64 id)
        {
            var rec = this.mnc.authors.Find(id);
            return View(rec);
        }
    }
}