using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.Models
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string SsnConfirm { get; set; }

        public DateTime Dob { get; set; }
        public EmployeeType Title { get; set; }
        public string LicNumber { get; set; }
        public DateTime LicIssue { get; set; }
        public DateTime LicExpire { get; set; }
        public DateTime MedIssue { get; set; }
        public DateTime MedExpire { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordConf { get; set; }




        // boolean to determine if compliant or not
        public bool DotCompliant { get; set; }

        // boolean to determine if employee is clockin or not
        public bool OnClock { get; set; }

        //boolean to determine if employee is available for work
        public bool EmployeeStatus { get; set; }




        public int EmployeeID { get; set; }

        public TractorDriverLoad DriverTractorLoad{get; set; }
    }
}
