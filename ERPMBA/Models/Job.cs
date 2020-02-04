using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Job
    {
        public string emplid { get; set; }
        public string Project { get; set; }
        public string Assignes { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public DateTime Hours { get; set; }
        public string RatePerHour { get; set; }
        public string Discription { get; set; }
        public string Attachment { get; set; }
        public string ReminderTime { get; set; }
        public string BillableStatus { get; set; }
    }
}