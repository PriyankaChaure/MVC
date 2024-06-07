using Assignment_on_codefirst.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Assignment_on_codefirst.Controllers
{
    public class TestController : Controller
    {
        contextclass cs=new contextclass();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.deptid = new SelectList(this.cs.dept1s.ToList(), "deptid", "deptname");
            return View(this.cs.emp1s.ToList());
        }
        //public ActionResult searchbydept(Int64 deptid = 0)
        //{
        //    ViewBag.deptid = new SelectList(this.cs.dept1s.ToList(), "deptid", "deptname");
        //    if (deptid == 0)
        //    {
        //        var v = this.cs.emp1s.ToList();
        //        return View("Index", v.ToList());
        //    }

        //    else
        //    {

        //        var rec = this.cs.emp1s.Where(p => p.deptid == deptid);
        //        return View("Index", rec.ToList());
        //    }

        //}
        public ActionResult searchbydept(Int64 deptid = 0, string opt="", decimal salary=0)
        {
            ViewBag.cityid = new SelectList(this.cs.city1s.ToList(), "cityid", "cityname");

            ViewBag.deptid = new SelectList(this.cs.dept1s.ToList(), "deptid", "deptname");
          
            switch(opt)
            {
                case "":
                    return RedirectToAction("Index");
                case "<":
                    var rec1 = from t in this.cs.emp1s.Where(p => (p.deptid == deptid) && (p.salary < salary))
                               select t;
                    return View("Index",rec1.ToList());
                case ">":
                    var rec2 = from t in this.cs.emp1s.Where(p => (p.deptid == deptid) && (p.salary > salary))
                               select t;
                    return View("Index", rec2.ToList());
                case "<=":
                    var rec3 = from t in this.cs.emp1s.Where(p => (p.deptid == deptid) && (p.salary <= salary))
                               select t;
                    return View("Index", rec3.ToList());
                case ">=":
                    var rec4 = from t in this.cs.emp1s.Where(p => (p.deptid == deptid) && (p.salary >= salary))
                               select t;
                    return View("Index", rec4.ToList());
                case "==":
                    var rec5 = from t in this.cs.emp1s.Where(p => (p.deptid == deptid) && (p.salary == salary))
                               select t;
                    return View("Index", rec5.ToList());
                default:
                    return RedirectToAction("Index");


            }

        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.deptid=new SelectList(this.cs.dept1s.ToList(),"deptid","deptname");
            ViewBag.cityid = new SelectList(this.cs.city1s.ToList(), "cityid", "cityname");
            return View();
        }
        [HttpPost]
        public ActionResult Create(emp1 rec)
        {
            ViewBag.deptid = new SelectList(this.cs.dept1s.ToList(), "deptid", "deptname");
            ViewBag.cityid = new SelectList(this.cs.city1s.ToList(), "cityid", "cityname");
            if (ModelState.IsValid)
            {
                this.cs.emp1s.Add(rec);
                this.cs.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec=this.cs.emp1s.Find(id);
            ViewBag.deptid = new SelectList(this.cs.dept1s.ToList(), "deptid", "deptname",rec.deptid);
            ViewBag.cityid = new SelectList(this.cs.city1s.ToList(), "cityid", "cityname",rec.cityid);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(emp1 rec)
        {
            ViewBag.deptid = new SelectList(this.cs.dept1s.ToList(), "deptid", "deptname", rec.deptid);
            ViewBag.cityid = new SelectList(this.cs.city1s.ToList(), "cityid", "cityname", rec.cityid);
            if(ModelState.IsValid)
            {
                this.cs.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                    this.cs.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.cs.emp1s.Find(id);
            this.cs.emp1s.Remove(rec);
            this.cs.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(Int64 id)
        {
            var rec = this.cs.emp1s.Find(id);
            return View(rec);
        }
    }
}




 

    