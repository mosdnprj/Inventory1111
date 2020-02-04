using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class TrainingFeedback
    {
        public string emplid { get; set; }
        public string WasItUseful { get; set; }
        public string WasItInlineWithYourExpectation { get; set; }
        public string ActionList { get; set; }
        public string WhichSubjectYouMostEnjoyed { get; set; }
        public string WhichSubjectYouLeastEnjoyed { get; set; }
    }
}