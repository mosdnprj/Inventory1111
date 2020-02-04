using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ERPMBA.Models
{
    public class CB
    {
        public string Name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BillNo { get; set; }
        public string Billdate { get; set; }
        public string Duedate { get; set; }

    }
}