using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookex.Models;

namespace bookex.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult showbook()
        {
            book b = new book();
            return View(b);
        }
        public ActionResult showmultibooks()
        {
            var v=book.getbooksinfo();
            return View(v);
        }
    }
}