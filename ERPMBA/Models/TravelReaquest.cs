using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class TravelReaquest
    {

        public string emplid { get; set; }
        public string EmployeeDepartment { get; set; }
        public DateTime ExpectedDateOfDeparture { get; set; }
        public string PurposeOfVisit { get; set; }
        public string PlaceOfVisit { get; set; }
        public string ExpectedDurationInDays { get; set; }
        public DateTime ExpectedDateOfArrival { get; set; }
        public string CustomerName { get; set; }
    }
}