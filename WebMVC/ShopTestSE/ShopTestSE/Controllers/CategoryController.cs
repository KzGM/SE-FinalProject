using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopTestSE.Models;

namespace ShopTestSE.Controllers
{
    public class CategoryController : Controller
    {
        ShopConn db = new ShopConn();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult CategoryPartial()
        {
            var categoryList = db.Categories.OrderBy(x => x.CategoryName).ToList();
            return PartialView(categoryList);
        }
    }
}