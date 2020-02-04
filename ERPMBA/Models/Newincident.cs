using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class NewIncident
    {

        public string loginuser { get; set; }
        public string Category { get; set; }
        public string ContactPerson { get; set; }
        public string incidenttype { get; set; }
        public string Servicetype { get; set; }
        public string businessimpact { get; set; }
        public string Urgency { get; set; }
        public string serviceitem { get; set; }
        public string IncidentSource { get; set; }
        public string AffectedEquipment { get; set; }
        public string AssignmentRule { get; set; }
        public string Attachfile { get; set; }
        public string incidentsummary { get; set; }
        public string DOI { get; set; }

    }
}