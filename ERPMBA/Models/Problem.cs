using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Problem
    {
        public string Facility { get; set; }
        public string Dept { get; set; }
        public string ReasonForSending { get; set; }
        public string Section { get; set; }
        public string Information { get; set; }
        public string DOD { get; set; }
        public string PInvestigator { get; set; }
        public string ProblemNbr { get; set; }
        public string Problemcomments { get; set; }

    }
}