using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class AssetManagement
    {
        public string Devicename { get; set; }
        public string AMType { get; set; }
        public string Policy { get; set; }
        public string Ownership { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string OS { get; set; }
        public string IMEI { get; set; }
        public string MACaddress { get; set; }
        public string Storage { get; set; }
    }
}