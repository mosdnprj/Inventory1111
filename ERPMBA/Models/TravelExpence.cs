using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class TravelExpence
    {
        public string emplid { get; set; }
        public string PurposeOfVisit { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string DiscriptionOfExpense { get; set; }
        public string Airfare { get; set; }
        public string Lodging { get; set; }
        public string GroundTransportation { get; set; }
        public string MealsTips { get; set; }
        public string Phone { get; set; }
        public string Miscellaneous { get; set; }
        public string ConferenceSeminors { get; set; }
        public string Total { get; set; }

    }
}