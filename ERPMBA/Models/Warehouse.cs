using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPMBA.Models
{
    public class Warehouse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Warehouseno { get; set; }
        public string Warehousename { get; set; }
        public string Warehouseloc { get; set; }

    }
}