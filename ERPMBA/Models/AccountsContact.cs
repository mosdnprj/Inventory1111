using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class AccountsContact
    {
        public string memberid { get; set; }
        public string accountid { get; set; }
        public string contactid { get; set; }
        public string date_entered { get; set; }
        public string date_modified { get; set; }
        public string deleted { get; set; }

    }
}