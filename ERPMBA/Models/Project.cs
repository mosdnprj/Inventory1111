using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Project
    {

        public string emplid { get; set; }
        public string ProjectNmae { get; set; }
        public string ClientName { get; set; }
        public string ProjectCost { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectUsers { get; set; }
    }
}