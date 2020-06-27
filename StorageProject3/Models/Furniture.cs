using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorageProject3.Models
{
    public class Furniture
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Depot Depot { get; set; }
        public int DepotId { get; set; }
        
    }
}