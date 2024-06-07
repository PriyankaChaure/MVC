using signin_signout.Models;
using signin_signout.patient_authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace signin_signout.Controllers
{
   [patientauthorize]
    public class DoctorController : Controller
    {
        patientcontext pc=new patientcontext();
        // GET: Doctor
        public ActionResult Index()
        {
            return View(this.pc.doctors.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(doctor record)
        {
            if (ModelState.IsValid)
            {
               this.pc.doctors.Add(record);
                this.pc.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(record);
        }
    }
}