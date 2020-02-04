using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPMBA.Models
{
    public class Rack
    {
        public string Warehouseno { get; set; }
        public string Storeno { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Rackno { get; set; }
        public string Rackname { get; set; }
        public string RRows { get; set; }
        public string Rackdesc { get; set; }
    }
}