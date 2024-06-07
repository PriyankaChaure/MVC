using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Mini_Project.Areas
{
    public class UserAreaController : Controller
    {
        // GET: UserArea
        public ActionResult Index()
        {
            return View();
        }
    }
}