using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Goals
    {
        public string GoalName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ManagerRating { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string UserRating { get; set; }
        public string Progress { get; set; }
        public string Job { get; set; }
    }
}