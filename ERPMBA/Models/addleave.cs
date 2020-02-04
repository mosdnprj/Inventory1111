using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class AddLeave
    {
        public string emplid { get; set; }
        public string Department { get; set; }
        public string LeaveType { get; set; }
        public string Other { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string NoOfDays { get; set; }
        public string NoInLeave { get; set; }
        public string AplyDate { get; set; }
        public string ResponsiblePerson { get; set; }
        public string ContactAddress { get; set; }
        public string remarks { get; set; }
    }
}