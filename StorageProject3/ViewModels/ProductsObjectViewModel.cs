using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StorageProject3.Models;

namespace StorageProject3.ViewModels
{
    public class ProductsObjectViewModel
    {
        public Product Product { get; set; }
        public Depot Depot { get; set; }
        public Location Location { get; set; }

        public List<Product> Products { get; set; }
    }
}