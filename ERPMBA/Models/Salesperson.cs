using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPMBA.Models
{
    public class Salesperson
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Sellerid { get; set; }
        public string Sellername { get; set; }
        public string Sellercontactno { get; set; }

    }
}