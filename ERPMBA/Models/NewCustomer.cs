using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ERPMBA.Models
{
    public class NewCustomer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Companyname { get; set; }
        public string Contactdisplayname { get; set; }
        public string Email { get; set; }
        public string Companymail { get; set; }
        public int Phoneno { get; set; }
        public int Mobileno { get; set; }
        public string Skype { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Website { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string States { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Payment { get; set; }
        
    }
}