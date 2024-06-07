using MVC_Templates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Templates.Controllers
{
    public class TestController : Controller
    {
        prachiEntities pr = new prachiEntities();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.dept = new SelectList(this.pr.depttbls.ToList(), "deptid", "deptname");
            return View(this.pr.emptbls.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.dept = new SelectList(this.pr.depttbls.ToList(), "deptid", "deptname");
            return View();
        }
        [HttpPost]
        public ActionResult Create(emptbl rec)
        {
            ViewBag.dept = new SelectList(this.pr.depttbls.ToList(), "deptid", "deptname");
            if (ModelState.IsValid)
            {
                this.pr.emptbls.Add(rec);
                this.pr.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(rec);
            }
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.pr.emptbls.SingleOrDefault(p => p.empid == id);
            ViewBag.dept = new SelectList(this.pr.depttbls.ToList(), "deptid", "deptname",rec.dept);
            return View(rec);
        }
        [HttpPost]  
        public ActionResult Edit(emptbl rec)
        {
            this.pr.Entry(rec).State = System.Data.Entity.EntityState.Modified;
            ViewBag.dept = new SelectList(this.pr.depttbls.ToList(), "deptid", "deptname", rec.dept);
            this.pr.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec=this.pr.emptbls.Find(id);
            this.pr.emptbls.Remove(rec);
            this.pr.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(Int64 id)
        {
            var rec = this.pr.emptbls.Find(id);
            return View(rec);
        }
    }
}