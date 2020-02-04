using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Leave
    {
        public string emplid { get; set; }
        public string TeamID { get; set; }
        public string LeaveType { get; set; }
        public DateTime from { get; set; }
        public DateTime DateofRequest { get; set; }
        public DateTime HoursTaken { get; set; }
        public string Reasonsforleave { get; set; }
        public string MedicalCertificate { get; set; }
    }
}