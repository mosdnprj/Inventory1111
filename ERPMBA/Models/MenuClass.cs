using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ERPMBA.Models
{
    public class MenuClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuAdded { get; set; }

    }
}