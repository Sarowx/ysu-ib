﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YSUIB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialWelcomeSection()
        {
            return PartialView();
        }
        
        public ActionResult PartialSlideshow()
        {
            return PartialView();
        }

    }
}