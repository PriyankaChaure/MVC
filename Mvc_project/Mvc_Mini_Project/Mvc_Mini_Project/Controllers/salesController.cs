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
    public class salesController : Controller
    {
       miniprocontext mnc=new miniprocontext();
        // GET: sales
        public ActionResult Index()
        {
            ViewBag.BookId = new SelectList(this.mnc.books.ToList(), "BookId", "BookName");
            return View(this.mnc.sales.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(this.mnc.books.ToList(), "BookId", "BookName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(sales rec)
        {
            ViewBag.BookId = new SelectList(this.mnc.books.ToList(), "BookId", "BookName");
            this.mnc.sales.Add(rec);
            this.mnc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.mnc.sales.SingleOrDefault(p => p.SalesId == id);
            ViewBag.BookId = new SelectList(this.mnc.books.ToList(), "BookId", "BookName",rec.BookId);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(sales rec)
        {
            this.mnc.Entry(rec).State = System.Data.Entity.EntityState.Modified;
            ViewBag.BookId = new SelectList(this.mnc.books.ToList(), "BookId", "BookName", rec.BookId);
            this.mnc.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.mnc.sales.Find(id);

            this.mnc.sales.Remove(rec);
            this.mnc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(Int64 id)
        {
            var rec = this.mnc.sales.Find(id);
            return View(rec);
        }

    }
}