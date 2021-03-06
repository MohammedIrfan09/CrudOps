using CrudOps.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOps.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductEntities dbobj = new ProductEntities();
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult GetProduct()
        {
            var list = dbobj.Products.ToList();
            return View(list);
        }
    }
}