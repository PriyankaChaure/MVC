using db_first_exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using db_first_exam.Models;
using System.Security.Cryptography;

namespace db_first_exam.Controllers
{
    public class TestController : Controller
    {

        // GET: Test
        prachiEntities p = new prachiEntities();
        public ActionResult Index()
        
        
        {
           
            ViewBag.projectid = new SelectList(this.p.projects.ToList(), "projectid", "projectname");
          
             
            var v = from t1 in this.p.projectassignments
                    join t2 in this.p.students
                    on t1.studentid equals t2.studentid
                    join t3 in this.p.projects
                    on t1.projectid equals t3.projectid
                  
                    group t1 by t3.projectname
                    into g
                    select new assignprostuproVM
                    {
                        //projectid=g.projectid,      
                        projectname = g.Key,
                        studentid = g.Count()
                    };
             return View(v);
        }
        //[HttpPost]
        public ActionResult searchbyproject(Int64 projectid=0) 
        {
            ViewBag.projectid = new SelectList(this.p.projects.ToList(), "projectid", "projectname");
            if (projectid == 0)
            {
               
                return RedirectToAction("Index",this.p.projects.ToList());
            }
            else
            {

                var v = from t1 in this.p.projectassignments
                        join t2 in this.p.students
                        on t1.studentid equals t2.studentid
                        join t3 in this.p.projects
                        on t1.projectid equals t3.projectid
                        where (t3.projectid == projectid)
                        group t1 by t3.projectname
                         into g
                        select new assignprostuproVM
                        {
                            //projectid = g.projectid,
                            projectname = g.Key,
                            studentid = g.Count()
                        };

                //s var rec = this.p.projectassignments.Where(p => p.projectid == projectid);
                return View("Index", v.ToList());
                //return RedirectToAction("Index", v.ToList());
            }
        }
    }
}