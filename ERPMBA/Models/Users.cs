using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class Users
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public string password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime Birthday { get; set; }
        public string SelectGender { get; set; }
        public string PermanentAddress { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string CurrentAddress { get; set; }
        public string LoginName { get; set; }
        public string JobTitle { get; set; }
        public string Manager { get; set; }
        public string ManagerName { get; set; }
        public int DepartamentNo { get; set; }
        public string DepartmentName { get; set; }
    }
}