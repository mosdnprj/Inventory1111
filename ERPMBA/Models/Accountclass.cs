using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Accountclass
    {
        public string memberid { get; set; }
        public string membername { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string date_entered { get; set; }
        public string date_modified { get; set; }
        public string deleted { get; set; }
        public string organisationtype { get; set; }
        public string organisationindustry { get; set; }
        public string phone { get; set; }
        public string assigned_user_id { get; set; }

    }
}