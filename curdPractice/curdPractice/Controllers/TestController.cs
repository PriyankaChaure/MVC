using curdPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace curdPractice.Controllers
{
    public class TestController : Controller
    {
        prachiEntities pr = new prachiEntities();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.studentdeptid = new SelectList(this.pr.studentdepts.ToList(), "studentdeptid", "studentdeptname");
            var rec = this.pr.studenttbls.ToList();
            return View(rec);
        }
        [HttpPost]
        public ActionResult searchbyname(string studentname)
        {
            ViewBag.studentdeptid = new SelectList(this.pr.studentdepts.ToList(), "studentdeptid", "studentdeptname");
            if (string.IsNullOrEmpty(studentname))
            {
                return View(this.pr.studenttbls.ToList());

            }
            else
            {
                var v= from t in this.pr.studenttbls
                       where t.studentname.StartsWith (studentname) 
                       select t;
                return View("Index",v.ToList());
            }
            
        }
       
        public ActionResult searchbydept(Int64 studentdeptid=0)
        {
            ViewBag.studentdeptid = new SelectList(this.pr.studentdepts.ToList(), "studentdeptid", "studentdeptname");
            if (studentdeptid==0)
            {
               var v= this.pr.studenttbls.ToList();
                return View("Index", v.ToList());
            }
          
           else
            {
                var rec = this.pr.studenttbls.Where(p => p.studentdeptid == studentdeptid);
                return View("Index",rec.ToList());
            }
            
        }
        [HttpGet]
        public ActionResult create()
        {
            ViewBag.studentdeptid = new SelectList(this.pr.studentdepts.ToList(), "studentdeptid", "studentdeptname");
            return View();
        }
        [HttpPost]
        public ActionResult create(studenttbl record) 
        { 
            this.pr.studenttbls.Add(record);
            this.pr.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult edit(Int64? id)
        {
            var rec=this.pr.studenttbls.SingleOrDefault(p=>p.studentid==id);
            ViewBag.studentdeptid = new SelectList(this.pr.studentdepts.ToList(), "studentdeptid", "studentdeptname",rec.studentdeptid);
            return View(rec);
        }
        [HttpPost]
        public ActionResult edit(studenttbl rec)
        {
            this.pr.Entry(rec).State=System.Data.Entity.EntityState.Modified;
            ViewBag.studentdeptid = new SelectList(this.pr.studentdepts.ToList(), "studentdeptid", "studentdeptname", rec.studentdeptid);
            this.pr.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]   
        public ActionResult delete(Int64? id)
        {
            var rec = this.pr.studenttbls.Find(id);
            this.pr.studenttbls.Remove(rec);
            this.pr.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}