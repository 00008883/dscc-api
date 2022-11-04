using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DSCC_8883.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string ProductProducer { get; set; }
        public DateTime ProducedDate { get; set; }
        public DateTime SuppliedDate { get; set; }
        public double Price { get; set; }
    }
}
