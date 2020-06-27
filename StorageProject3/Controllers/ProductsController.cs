using StorageProject3.Models;
using StorageProject3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace StorageProject3.Controllers
{
    public class ProductsController : Controller
    {

        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        // GET: Products
        
        [Authorize(Roles = RoleName.CanStoreProduct)]
        public ActionResult Index()
        {
            var products = _context.Products.Include( p => p.Location).ToList();
            return View(products);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        

        // POST: Products/Create
        [HttpPost]
        [Authorize(Roles = RoleName.CanStoreProduct)]
        public ActionResult Create(Product products )
        {
            var productName = Request.Params["Product.Name[]"];
           var productNameList = productName.Split(',').ToList();

            var locationAddress = Request.Params["Location.Address[]"];
            var locationAddressList = locationAddress.Split(',').ToList();
            //Product entity = _context.Products.Create();

            //entity.Name = "Test Name";
            //entity.ClientID = 4;

            //db.Surveys.Add(entity);
            //db.SaveChanges();

            List<Product> productList = new List<Product>();
            foreach (var item in productNameList)
            {
                var product = new Product();
                product.Name = item;
                productList.Add(product);
            }

            List<Location> locationList = new List<Location>();
            foreach (var item in locationAddressList)
            {
                var location = new Location();
                location.Address = item;
                locationList.Add(location);
            }




            try
            {

                for (int i = 0; i < productList.Count; i++)
                {
                    _context.Products.Add(productList[i]);
                    _context.Locations.Add(locationList[i]);
                    _context.SaveChanges();
                }
                //foreach (var p in productList)
                //{
                //   _context.Products.Add(p);
                //}
                //foreach (var l in locationList)
                //{
                //    _context.Locations.Add(l);
                //}
               
                // TODO: Add insert logic here


                return RedirectToAction("Index", "Products");
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
