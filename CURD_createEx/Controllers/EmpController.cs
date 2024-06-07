using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using CURD_createEx.Models;
namespace CURD_createEx.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        prachiEntities p=new prachiEntities();
        public ActionResult Index()
        {
            ViewBag.dept=new SelectList(this.p.depttbls.ToList(),"deptid","deptname");
            var v = this.p.emptbls.ToList();
            return View(v);
        }
        public ActionResult SearchByName(string Ename) 
        {
            ViewBag.dept= new SelectList(this.p.depttbls.ToList(),"deptid","deptname");
            if(Ename=="")
              return View("Index",this.p.emptbls.ToList());
            else
            {
                var v=from t in this.p.emptbls
                      where t.empname .StartsWith(Ename)
                      select t;
                return View("Index",v.ToList());
            }
        }
        public ActionResult SearchByDep(Int64 dept=0)
        {
            ViewBag.dept=new SelectList(this.p.depttbls.ToList(), "deptid", "deptname");
            if (dept==0)
            {
                return View("Index", this.p.emptbls.ToList());
            }
            else
            {
                var rec = this.p.emptbls.Where(p => p.dept==dept);
                return View("index", rec.ToList());
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.dept=new SelectList(this.p.depttbls.ToList(),"deptid","deptname");
            return View(); 
        }
        [HttpPost]
        public ActionResult Create(emptbl rec)
        {
            //ViewBag.dept =new SelectList(this.p.depttbls.ToList(), "deptid", "deptname");
            this.p.emptbls.Add(rec);
            this.p.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult edit(Int64 id)
        {
            var rec = this.p.emptbls.SingleOrDefault(p => p.empid == id);
            ViewBag.dept = new SelectList(this.p.depttbls.ToList(), "deptid", "deptname",rec.dept);
            
            return View(rec);  
        }
        [HttpPost] 
        public ActionResult edit(emptbl rec)
        {
            this.p.Entry(rec).State = System.Data.Entity.EntityState.Modified;
            //var oldrec = this.p.emptbls.SingleOrDefault(p => p.empid == rec.empid);
            ViewBag.dept = new SelectList(this.p.depttbls.ToList(), "deptid", "deptname", rec.dept);
            //oldrec.empname = rec.empname;
            //oldrec.address = rec.address;
            //oldrec.emailid = rec.emailid;
            //oldrec.mono = rec.mono;
            //oldrec.salary = rec.salary;
            //oldrec.dept = rec.dept;
            this.p.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult delete(Int64 id) 
        {
            var rec= this.p.emptbls.Find(id);
          
            this.p.emptbls.Remove(rec);
            this.p.SaveChanges();
            return RedirectToAction("Index"); 
        } 
    }
}