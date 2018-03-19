using System;
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

        public ActionResult Faculty(int id)
        {
            return View();
        }

        public ActionResult Facultyes()
        {
            return View();
        }

        public ActionResult News()
        {
            return PartialView();
        }

        public ActionResult Applicant()
        {
            return View();
        }

        public ActionResult Staff()
        {
            return View();
        }

        public ActionResult Specializations(int faculty)
        {
            return View();
        }

        public ActionResult Ambions(int faculty)
        {
            return View();
        }


    }
}