using Academy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy.Controllers
{
    public class FurnitorController : Controller
    {
        ApplicationDbContext DbContext = new ApplicationDbContex();
        // GET: Furnitor
        public ActionResult Index()
        {
            var furnitorData = DbContext.furnitors.ToList();
            return View(furnitorData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Furnitor furnitor)
        {
            furnitor.dateSaved = DateTime.Now;
            if (ModelState.IsValid)
            {
                DbContext.furnitors.Add(furnitor);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(furnitor);
        }
    }
}