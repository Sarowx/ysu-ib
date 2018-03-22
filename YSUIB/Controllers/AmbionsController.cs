using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YSUIB.Controllers
{
    public class AmbionsController : Controller
    {
        // GET: Ambion
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialSidebar()
        {
            return PartialView();
        }
        public ActionResult PartialList()
        {

            return PartialView();
        }
    }
}