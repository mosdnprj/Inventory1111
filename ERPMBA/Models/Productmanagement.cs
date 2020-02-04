using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Productmanagement
    {
        public string ProductId { get; set; }
        public string Producttype { get; set; }
        public string SerialNumber { get; set; }
        public string ProductDescription { get; set; }
        public string CatageoryId { get; set; }
        public string SubCatageoryId { get; set; }
        public string Discontinued { get; set; }
        public string Barcode { get; set; }
        public string UnitPrice { get; set; }
        public string SalesMarkup { get; set; }
        public string Leadtime { get; set; }
        public string AnnualorderQunatity { get; set; }
        public string Annualworkingday { get; set; }
        public string LocationId { get; set; }
        public string Unitsonorder { get; set; }
        public string Unitssold { get; set; }
        public string Totalinventory { get; set; }
        public string SuggestsalesPrice { get; set; }
        public string ValidFrom { get; set; }
        public string ValidTo { get; set; }



    }
}