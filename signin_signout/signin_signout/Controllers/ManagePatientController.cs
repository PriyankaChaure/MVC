using signin_signout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace signin_signout.Controllers
{
    
    public class ManagePatientController : Controller
    {
        patientcontext pc = new patientcontext();
        // GET: ManagePatient
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(signinpatient record)
        {
            var patientrec=this.pc.patients.SingleOrDefault(p=>p.emailid==record.emailid && p.password==record.password);
            if(ModelState.IsValid)
            {
                if(patientrec!=null)
                {
                    Session["patientid"] =patientrec.patientid;
                    Session["patientname"] = patientrec.patientname;
                    return RedirectToAction("Index","Doctor");
                }
                ModelState.AddModelError("", "invalid email id or password!!!");
                return View(record);
            }
            
            return View(record);
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(patient rec)
        {
            if(ModelState.IsValid)
            {
                this.pc.patients.Add(rec);
                this.pc.SaveChanges();
                return RedirectToAction("SignIn");
            }
            return View(rec);
        }
        [HttpGet]
        public ActionResult SignOut()
        {
            Session.Clear();
            Session.Abandon();
            return View();
        }

    }
}