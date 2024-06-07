using Mvc_Mini_Project.Models;
using Mvc_Mini_Project.Models.User_Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Mini_Project.Areas.UserArea.Controllers
{
    public class ManageUsersController : Controller
    {
        miniprocontext mnc = new miniprocontext();
        // GET: UserArea/ManageUsers
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
                var urec = this.mnc.admins.SingleOrDefault(p => p.UserName == rec.UserName && p.Password == rec.Password);
                if (urec != null)
                {
                    Session["AdminId"] = urec.AdminId;
                    Session["FirstName"] = urec.FirstName;
                    return RedirectToAction("Index", "UserAreaHome", new { area = "UserArea" });
                }
                ModelState.AddModelError("", " Invalid UserName Or Password");
                return View(rec);
            }
            return View(rec);
        }
        public ActionResult LogOut()
        {
            Session.Clear();
            Session.Abandon();
            return View();
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
    }
}