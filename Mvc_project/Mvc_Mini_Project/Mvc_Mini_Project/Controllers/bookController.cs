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
    public class bookController : Controller
    {
        miniprocontext mnc = new miniprocontext();
        // GET: book
        public ActionResult Index()
        {
            ViewBag.SubjectId = new SelectList(this.mnc.subjects.ToList(), "SubjectId", "SubjectName");
            ViewBag.AuthorId = new SelectList(this.mnc.authors.ToList(), "AuthorId", "AuthorName");
            return View(this.mnc.books.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.SubjectId = new SelectList(this.mnc.subjects.ToList(), "SubjectId", "SubjectName");
            ViewBag.AuthorId = new SelectList(this.mnc.authors.ToList(), "AuthorId", "AuthorName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(book rec)
        {
            ViewBag.SubjectId = new SelectList(this.mnc.subjects.ToList(), "SubjectId", "SubjectName");
            ViewBag.AuthorId = new SelectList(this.mnc.authors.ToList(), "AuthorId", "AuthorName");
            this.mnc.books.Add(rec);
            this.mnc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.mnc.books.SingleOrDefault(p => p.BookId == id);
            ViewBag.SubjectId = new SelectList(this.mnc.subjects.ToList(), "SubjectId", "SubjectName",rec.SubjectId);
            ViewBag.AuthorId = new SelectList(this.mnc.authors.ToList(), "AuthorId", "AuthorName",rec.AuthorId);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(book rec)
        {
            this.mnc.Entry(rec).State = System.Data.Entity.EntityState.Modified;
            ViewBag.SubjectId = new SelectList(this.mnc.subjects.ToList(), "SubjectId", "SubjectName", rec.SubjectId);
            ViewBag.AuthorId = new SelectList(this.mnc.authors.ToList(), "AuthorId", "AuthorName", rec.AuthorId);
            this.mnc.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.mnc.books.Find(id);

            this.mnc.books.Remove(rec);
            this.mnc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(Int64 id)
        {
            var rec = this.mnc.books.Find(id);
            return View(rec);
        }
    }
}