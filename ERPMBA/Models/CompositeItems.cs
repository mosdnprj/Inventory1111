using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class CompositeItems
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Unit { get; set; }
        public string Item { get; set; }
        public string Quantity { get; set; }
        public string Itemsellingprice { get; set; }
        public string Itempurchaseprice { get; set; }
        public string UPC { get; set; }
        public string MPN { get; set; }
        public string EAN { get; set; }
        public string ISBN { get; set; }
        public string SellingPrice { get; set; }
        public string PurchasePrice { get; set; }
        public string SalesAcc { get; set; }
        public string PurchaseAcc { get; set; }
        public string SalesDesc { get; set; }
        public string PurchaseDesc { get; set; }
        public string Preffervend { get; set; }
        public string InventAcc { get; set; }
        public string ReorderLevel { get; set; }
        public string OpeningStock { get; set; }
        public string Openingstckval { get; set; }
    }
}