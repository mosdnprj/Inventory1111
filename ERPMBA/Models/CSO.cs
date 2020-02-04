using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPMBA.Models
{
    public class CSO
    {

        public string CustomerName { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SalesOrder { get; set; }
        public string Reference { get; set; }
        public string SalesOrderdate { get; set; }
        public string ExpecShipDate { get; set; }
        public string SalesPerson { get; set; }
        public string DeliveryMethod { get; set; }
        public string PaymentType { get; set; }

    }
}