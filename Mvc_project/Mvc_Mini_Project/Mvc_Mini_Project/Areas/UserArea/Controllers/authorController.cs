using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Mini_Project.Areas.UserArea.Controllers
{
    public class authorController : Controller
    {
        // GET: UserArea/author
        public ActionResult Index()
        {
            return View();
        }
    }
}