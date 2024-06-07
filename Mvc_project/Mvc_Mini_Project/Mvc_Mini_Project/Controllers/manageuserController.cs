using Mvc_Mini_Project.Models;
using Mvc_Mini_Project.Models.User_Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Mvc_Mini_Project.Controllers
{
   
    public class manageuserController : Controller
    {
        miniprocontext mnc = new miniprocontext();
        // GET: manageuser
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(sign_in_class rec)
        {
            if (ModelState.IsValid)
            {
                var userrec = this.mnc.admins.SingleOrDefault(p => p.UserName == rec.UserName && p.Password == rec.Password);
                if (userrec != null)
                {
                    Session["AdminId"] = userrec.AdminId;
                    Session["Firstname"] = userrec.FirstName;
                    return RedirectToAction("Index", "sales");
                }
                ModelState.AddModelError("", "invalid email id or password!!!");
                return View(rec);
            }
            return View(rec);
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(admin rec)
        {
            if (ModelState.IsValid)
            {
                this.mnc.admins.Add(rec);
                this.mnc.SaveChanges();
                return RedirectToAction("SignIn");
            }
            return View(rec);
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            Session.Abandon();
            return View();
        }
    }
}