using codefirstexam_akash_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codefirstexam_akash_.Controllers
{
    public class TestController : Controller
    {
        batchcontext bc=new batchcontext();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.courseid = new SelectList(this.bc.courses.ToList(), "courseid", "coursename");
            ViewBag.trainerid = new SelectList(this.bc.trainers.ToList(), "trainerid", "trainername");
            ViewBag.batchid = new SelectList(this.bc.batches.ToList(), "batchid", "startdate");
            return View(this.bc.batches.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.courseid=new SelectList(this.bc.courses.ToList(),"courseid","coursename");
            ViewBag.trainerid = new SelectList(this.bc.trainers.ToList(), "trainerid", "trainername");
            ViewBag.batchid = new SelectList(this.bc.batches.ToList(), "batchid", "startdate");
            return View();
        }
        [HttpPost]
        public ActionResult Create(batch rec)
        {
            ViewBag.courseid = new SelectList(this.bc.courses.ToList(), "courseid", "coursename");
            ViewBag.trainerid = new SelectList(this.bc.trainers.ToList(), "trainerid", "trainername");
            ViewBag.batchid = new SelectList(this.bc.batches.ToList(), "batchid", "startdate");
            if (ModelState.IsValid)
            {
                this.bc.batches.Add(rec);
                this.bc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}