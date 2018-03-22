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
        // GET: Faculty
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialSidebar()
        {
            var db = new UniversityEntities();
            var model = db.Faculties.ToList();

            return PartialView(model);
        }

        public ActionResult PartialList()
        {

            return PartialView();
        }
    }
}