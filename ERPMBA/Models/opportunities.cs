using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class opportunities
    {
        public string memberid { get; set; }
        public string fullname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public DateTime DOB { get; set; }
        public string citizenship { get; set; }
        public string Race { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string postalcode { get; set; }
        public DateTime date_entered { get; set; }
        public DateTime date_modified { get; set; }
        public string deleted { get; set; }
        public string opportunity_type { get; set; }
        public string assigned_user_id { get; set; }

    }
}