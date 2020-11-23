using Academy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace Academy.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext DbContext = new ApplicationDbContex();
        // GET: Product
        public ActionResult Index()
        {
            var product = DbContext.produkts.Include(p => p.furnitors).ToList();
            return View(product);
        }
        [HttpGet]
        public ActionResult CreateProd()
        {
            var furnitor = DbContext.furnitors.ToList();
            ViewData["furnitor"] = furnitor;


            return View();
        }
        [HttpPost]
        public ActionResult CreateProd(Produkt produkt)
        {
            if (ModelState.IsValid)
            {
                DbContext.produkts.Add(produkt);
                DbContext.SaveChanges();
                return RedirectToAction("Index","Product");
            }
            return View(produkt);
        }
    }
}