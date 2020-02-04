using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPMBA.Models
{
    public class Store
    {   
        public string Warehouseno { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Storeno { get; set; }
        public string Rows { get; set; }
        public string Cols { get; set; }
        public string Storename { get; set; }
        public string Storedesc { get; set; }
    }
}