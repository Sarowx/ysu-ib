using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YSUIB.Models.Data;

namespace YSUIB.Controllers
{
    public class SharedController : Controller
    {
        public PartialViewResult PartialNavbarList()
        {
            var db = new UniversityEntities();

            var model = (from item in db.MenuItems
                         where item.Type == "navbar"
                         select item).ToList();

            return PartialView(model);
        }
    }
}