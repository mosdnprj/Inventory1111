using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class TrainingRegistration
    {
        public string emplid { get; set; }
        public string TrainingId { get; set; }
        public string Reason { get; set; }
        public string TrainingTitle { get; set; }
        public string Venue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PaidBy { get; set; }
        public string AmountPaidByEmployee { get; set; }
        public DateTime PaidDate { get; set; }
        public string Remarks { get; set; }
    }
}