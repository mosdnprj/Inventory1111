using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Problemslist
    {
        public string ProblemId { get; set; }
        public string contact { get; set; }
        public string status { get; set; }
        public string service { get; set; }
        public string summary { get; set; }
        public string assignedto { get; set; }
        public string timetoresolve { get; set; }
    }
}