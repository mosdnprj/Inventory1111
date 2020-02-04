using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class NewBill
    {
        public string Itemdetails { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Amount { get; set; }
        public string Tax { get; set; }
    }
}