using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPMBA.Models
{
    public class CPO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PurchaseOrder1 { get; set; }
        public string TraderName { get; set; }
        public string Purchasenbr { get; set; }
        public string Reference { get; set; }
        public string Transdate { get; set; }
        public string ExpctdDelDate { get; set; }
        public string ShipPref { get; set; }

    }
}