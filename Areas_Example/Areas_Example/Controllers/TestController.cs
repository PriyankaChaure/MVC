﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas_Example.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult MainIndex()
        {
            return View();
        }
    }
}