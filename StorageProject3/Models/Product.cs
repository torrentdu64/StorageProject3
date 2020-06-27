using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StorageProject3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int MyProperty { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
    }
}