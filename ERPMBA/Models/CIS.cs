using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPMBA.Models
{
    public class CIS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string InvoiceNo { get; set; }
        public string InvoiceDate { get; set; }
        public string OrderNo { get; set; }
        public string Reference { get; set; }
        public string Paymentterms { get; set; }
        public string Duedate { get; set; }
        public string CustomerName { get; set; }
        public string ShipAddress { get; set; }

    }
}
