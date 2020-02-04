using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class PerformanceAppraisal
    {
        public string emplid { get; set; }
        public string Department { get; set; }
        public DateTime Date { get; set; }
        public string PeriodofReview { get; set; }
        public string Reviewer { get; set; }
        public string JobKnowledge { get; set; }
        public string Productivity { get; set; }
        public string WorkQuality { get; set; }
        public string TechnicalSkils { get; set; }
        public string WorkConsistency { get; set; }
        public string Enthusiasm { get; set; }
        public string Cooperation { get; set; }
        public string Attitude { get; set; }
        public string Intiative { get; set; }
        public string WorkRelations { get; set; }
        public string Creativity { get; set; }
        public string Puntuality { get; set; }
        public string Attendance { get; set; }
        public string CommunicationSkills { get; set; }
        public string OveralRating { get; set; }
    }
}