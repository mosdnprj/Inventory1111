using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Work
    {
        public string emplid { get; set; }
        public string Companyname { get; set; }
        public DateTime Workedfrom { get; set; }
        public string Designation { get; set; }
        public DateTime WorkedTo { get; set; }
        public string Category { get; set; }
       

    }
}