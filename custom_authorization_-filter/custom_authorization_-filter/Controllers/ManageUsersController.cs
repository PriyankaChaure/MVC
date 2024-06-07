using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using custom_authorization__filter.Models.UserVM;
using custom_authorization__filter.Models;

namespace custom_authorization__filter.Controllers
{

    public class ManageUsersController : Controller
    {
        chaureEntities ch = new chaureEntities();
        // GET: ManageUsers
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(signinclass rec)
        {
            if(ModelState.IsValid)
            {
                var userrec=this.ch.usertbls.SingleOrDefault(p=>p.emailid==rec.emailid && p.password==rec.password);
                if(userrec!=null)
                {
                    Session["userid"] = userrec.userid;
                    Session["firstname"]=userrec.firstname;
                    return RedirectToAction("Index","Test");
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
        public ActionResult SignUp(usertbl rec)
        {
            if(ModelState.IsValid)
            {
                this.ch.usertbls.Add(rec);
                this.ch.SaveChanges();
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