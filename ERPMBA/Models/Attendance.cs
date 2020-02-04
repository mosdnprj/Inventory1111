using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Attendance
    {
        public string emplid { get; set; }
        public string empname { get; set; }
        public string Leave { get; set; }
        public string Reason { get; set; }
        public string Intimation { get; set; }
        public DateTime Timein { get; set; }
        public DateTime Timeout { get; set; }
        public DateTime Date { get; set; }
    }
}