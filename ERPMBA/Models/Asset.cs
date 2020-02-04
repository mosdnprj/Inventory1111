using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    
        public class Asset
        {
            public string emplid { get; set; }
            public DateTime GivenDate { get; set; }
            public string AssetDetails { get; set; }
            public string TypeofAsset { get; set; }
            public DateTime ReturnDate { get; set; }
        }
    }
