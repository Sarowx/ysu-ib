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
        private IQueryable<Article> GetArticles(string orderBy = "views", string sort = "desc", int limit = int.MaxValue, int offset = 0)
        {
            orderBy = orderBy.ToLower();
            sort = sort.ToLower();

            var db = new UniversityEntities();
           
            IOrderedQueryable<Article> orderedQuery;

            switch (orderBy)
            {
                case "views":
                    {
                        if (sort == "desc" || sort == "descending")
                        {
                            orderedQuery = db.Articles.OrderByDescending(art => art.Views);
                        }
                        else
                        {
                            orderedQuery = db.Articles.OrderBy(art => art.Views);
                        }
                        break;
                    }

                case "date":
                    {
                        if (sort == "desc" || sort == "descending")
                        {
                            orderedQuery = db.Articles.OrderByDescending(art => art.PublishDateTime);
                        }
                        else
                        {
                            orderedQuery = db.Articles.OrderBy(art => art.PublishDateTime);
                        }
                        break;
                    }

                case "title":
                    {
                        if (sort == "desc" || sort == "descending")
                        {
                            orderedQuery = db.Articles.OrderByDescending(art => art.TitleTranslation.Value);
                        }
                        else
                        {
                            orderedQuery = db.Articles.OrderBy(art => art.TitleTranslation.Value);
                        }
                        break;
                    }
                default:
                    {
                        if (sort == "desc" || sort == "descending")
                        {
                            orderedQuery = db.Articles.OrderByDescending(art => art.Views);
                        }
                        else
                        {
                            orderedQuery = db.Articles.OrderBy(art => art.Views);
                        }
                        break;
                    }
            }

            var query = orderedQuery.Skip(offset).Take(limit);

            return query;
        }

        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Article(int? id)
        {
            if (!id.HasValue)
            {
                return View("Error", "Shared", null);
            }

            var db = new UniversityEntities();

            var article = db.Articles.Find(new { id = id });

            return View(article);
        }
        public ActionResult PartialSection(string orderBy="views", string sort="desc", int limit = 4)
        {
            var model = GetArticles(orderBy: orderBy, sort: sort, limit: limit).ToList();

            return PartialView(model);
        }
    }
}