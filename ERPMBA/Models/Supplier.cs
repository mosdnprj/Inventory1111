using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ERPMBA.Models
{
    public class Supplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SupplierID { get; set; }
      //  public string Salutation { get; set; }
        public string SupplierName { get; set; }
        public string Companyname { get; set; }
        public string Email { get; set; }
        public string Mobileno { get; set; }
        public string Webpage { get; set; }
        public string Suppliergroup { get; set; }
        public string Businesstype { get; set; }
        public string Deliveryterms { get; set; }
        public string Tax { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
        public string Bank { get; set; }
        public int Accountno { get; set; }
        public string Ifsc { get; set; }
        public string Paymentdeadline { get; set; }
        public string Currency { get; set; }
        public string Paymentmethod { get; set; }

    }
}