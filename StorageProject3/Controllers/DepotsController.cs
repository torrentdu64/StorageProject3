using StorageProject3.Models;
using StorageProject3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageProject3.Controllers
{
    public class DepotsController : Controller
    {
        private ApplicationDbContext _context;

        public DepotsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        // GET: Depots
        [Authorize(Roles = RoleName.CanStoreProduct)]
        public ActionResult Index()
        {
            //var depots = _context.Depots.ToList();
            return View();
        }

        [Route("Depots/Show/{id}")]
        [AllowAnonymous]
        public ActionResult Show(int id)
        {

          // var depot =  _context.Depots.SingleOrDefault(m => m.Id == id);
            // var product = new Product();
            var products = new List<Product>();
            var location = new Location();
            var viewModel = new ProductsObjectViewModel
            {
                //Depot = depot,
                Products = products,
                Location = location
            };

            if (User.IsInRole(RoleName.CanStoreProduct))
                return View("ShowAdmin", viewModel);

            //return View("Show", depot);
            return View();
        }
        [AllowAnonymous]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Create(Depot depot)
        {
           // _context.Depots.Add(depot);
            _context.SaveChanges();

            TempData["message"] = "Deposit Successfully record";
            return RedirectToAction("Show","Depots", new { depot.Id });
        }
    }
}