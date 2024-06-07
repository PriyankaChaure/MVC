using code_first_exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace code_first_exam.Controllers
{
    public class TestController : Controller
    {
        bookcontext bc=new bookcontext();
        // GET: Test
        public ActionResult Index()
        {
            return View(this.bc.books.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.bookcatid = new SelectList(this.bc.bookcategories.ToList(), "bookcatid", "bookcatname");
            ViewBag.authorid = new SelectList(this.bc.authors.ToList(), "authorid", "authorname");
            ViewBag.publisherid = new SelectList(this.bc.publisher.ToList(), "publisherid", "publishername");
            return View();
        }
        [HttpPost]
        public ActionResult Create(book rec)
        {
            ViewBag.bookcatid = new SelectList(this.bc.bookcategories.ToList(), "bookcatid", "bookcatname");
            ViewBag.authorid = new SelectList(this.bc.authors.ToList(), "authorid", "authorname");
            ViewBag.publisherid = new SelectList(this.bc.publisher.ToList(), "publisherid", "publishername");
            if (ModelState.IsValid)
            {
                this.bc.books.Add(rec);
                this.bc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }
    }
}