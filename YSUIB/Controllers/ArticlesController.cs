using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YSUIB.Models.Data;

namespace YSUIB.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialSection(string order="views", string sort="desc", int quantity = 4)
        {

            return PartialView();
        }
    }
}