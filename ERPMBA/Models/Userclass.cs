using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{


    public class Userclass
    {
        public string userid { get; set; }
        public string username { get; set; }

        public string email { get; set; }
        public string firstname { get; set; }
        public string secondname { get; set; }
        public string moblieno { get; set; }
        public string password { get; set; }
        public string Telephoneno { get; set; }
        public string Image_User { get; set; }

    }


}