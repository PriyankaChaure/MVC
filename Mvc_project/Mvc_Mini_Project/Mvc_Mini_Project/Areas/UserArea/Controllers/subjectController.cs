using Mvc_Mini_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Mini_Project.Authentication;

namespace Mvc_Mini_Project.Controllers
{
    [UserAuthentication]
    public class subjectController : Controller
    {
        miniprocontext mnc = new miniprocontext();
        // GET: subject
        public ActionResult Index()
        {
            return View(this.mnc.subjects.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(subject rec)
        {
            this.mnc.subjects.Add(rec);
            this.mnc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.mnc.subjects.SingleOrDefault(p => p.SubjectId == id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(subject rec)
        {
            this.mnc.Entry(rec).State = System.Data.Entity.EntityState.Modified;
            this.mnc.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.mnc.subjects.Find(id);

            this.mnc.subjects.Remove(rec);
            this.mnc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(Int64 id)
        {
            var rec = this.mnc.subjects.Find(id);
            return View(rec);
        }
    }
}