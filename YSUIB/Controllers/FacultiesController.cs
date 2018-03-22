using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YSUIB.Models.Data;

namespace YSUIB.Controllers
{
    public class FacultiesController : Controller
    {
        UniversityEntities db = new UniversityEntities();

        // GET: Faculty
        public ActionResult Index()
        {
            var model = db.Faculties.ToList();

            return View(model);
        }
        public ActionResult PartialSidebar()
        {
            var model = db.Faculties.ToList();

            return PartialView(model);
        }

        public ActionResult PartialList()
        {

            return PartialView();
        }
    }
}