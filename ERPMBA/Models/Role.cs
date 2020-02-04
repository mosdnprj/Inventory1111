using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ERPMBA.Models
{
    public class Role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string Comments { get; set; }
        public string Inventory { get; set; }
        public string Users { get; set; }
        public string Product { get; set; }
        public string Orders { get; set; }
        public string Billing { get; set; }
        public string Packages { get; set; }
        public string Stack { get; set; }
        public string Integration { get; set; }
        public string Reports { get; set; }
        public string HR { get; set; }
        public string CRM { get; set; }
        public string ITSMS { get; set; }
        public string Dashboard { get; set; }
    }
}