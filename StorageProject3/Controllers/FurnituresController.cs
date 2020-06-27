using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StorageProject3.Models;

namespace StorageProject3.Controllers
{
    public class FurnituresController : Controller
    {
        private ApplicationDbContext _context;

        public FurnituresController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        // GET: Furnitures
        public ActionResult Index()
        {
            var furnitures = _context.Furnitures.ToList();
            return View(furnitures);
        }

        [AllowAnonymous]
        public ActionResult New()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Create(Furniture furniture)
        {
            _context.Furnitures.Add(furniture);
            _context.SaveChanges();

            TempData["message"] = "Deposit Successfully record";
            return RedirectToAction("Show", "Furnitures", new { furniture.id });
        }


    }
}