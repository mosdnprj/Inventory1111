using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Exitdetails
    {

        public string emplid { get; set; }
        public DateTime DateOfJoin { get; set; }
        public DateTime DateOfLeaving { get; set; }
        public string ReasonToLeaveTheCompany { get; set; }
        public string YourWorkEnvironment { get; set; }
        public string YourWorkSchdule { get; set; }
        public string YourCompensation { get; set; }
        public string YourBenefitsFromCompany { get; set; }
    }
}