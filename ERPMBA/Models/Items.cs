using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ERPMBA.Models
{
    public class Items
    {
        
        public string Productname { get; set; }
        public string Image_Item { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ProductID { get; set; }
        public string Unit { get; set; }
        public string Quantity { get; set; }
        public string Categoryname { get; set; }
        public string Brandname { get; set; }
        public string UPC { get; set; }
        public string MPN { get; set; }
        public string EAN { get; set; }
        public string SellingPrice { get; set; }
        public string PurchasePrice { get; set; }
        public string SupplierID { get; set; }
        

    }
    public class ItemCategory
    {
        public string Categoryname { get; set; }

    }
    public class ItemBrand
    {
        public string Brandname { get; set; }

    }

}