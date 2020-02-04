using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPMBA.Models
{
    public class Row
    {
        public string Warehouseno { get; set; }
        public string Storeno { get; set; }
        public string Rackno { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Rowno { get; set; }
        public string Rowname { get; set; }
        public string Rowdesc { get; set; }
    }
}