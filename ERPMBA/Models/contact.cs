using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class contact
    {
        public string memberid { get; set; }
        public string fullname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public DateTime DOB { get; set; }
        public string citizenship { get; set; }
        public string Race { get; set; }
        public int mobile { get; set; }
        public string email { get; set; }
        public int postalcode { get; set; }
        public DateTime date_entered { get; set; }
        public DateTime date_modified { get; set; }
        public string deleted { get; set; }
        public string assigned_user_id { get; set; }



    }
}