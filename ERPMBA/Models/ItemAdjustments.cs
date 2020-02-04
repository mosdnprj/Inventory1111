using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class ItemAdjustments
    {
        public string AdjustMode { get; set; }
        public string Reference { get; set; }
        public DateTime Date { get; set; }
        public string Account { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public string Itemdetails { get; set; }
        public int Quantityavail { get; set; }
        public int Newquantity { get; set; }
        public int Quantityadjust { get; set; }

    }
}