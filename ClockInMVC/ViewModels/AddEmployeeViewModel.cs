using ClockInMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.ViewModels
{
    public class AddEmployeeViewModel
    {
        [Required(ErrorMessage = "You must provide the first name")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "You must provide the last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must provide the social security number")]
        public string SSN { get; set; }

        [Required(ErrorMessage = "You must confirm social security number")]
        public string SsnConfirm { get; set; }


        [Required(ErrorMessage = "You must provide date of birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }


        [Required(ErrorMessage = "You must provide the driver's license number")]
        public string LicNumber { get; set; }

        [Required(ErrorMessage = "You must provide the driver's license issue date")]
        [DataType(DataType.Date)]
        public DateTime LicIssue { get; set; }

        [Required(ErrorMessage = "You must provide the driver's license expiration date")]
        [DataType(DataType.Date)]
        public DateTime LicExpire { get; set; }

        [Required(ErrorMessage = "You must provide the medical card issue date")]
        [DataType(DataType.Date)]
        public DateTime MedIssue { get; set; }

        [Required(ErrorMessage = "You must provide the medical card exipration date")]
        [DataType(DataType.Date)]
        public DateTime MedExpire { get; set; }

        [Required(ErrorMessage = "You must provide the Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "You must provide password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must confirm password")]
        public string PasswordConf { get; set; }

        //needs atttention
        [Required(ErrorMessage = "You must provide the Employee title ")]
        public EmployeeType Title { get; set; }

        public string TodaysDate { get; set; }

        public List<SelectListItem> EmployeeTitles { get; set; }

        public AddEmployeeViewModel()
        {
            EmployeeTitles = new List<SelectListItem>();

            EmployeeTitles.Add(new SelectListItem
            {
                Value = ((int)EmployeeType.Dispatcher).ToString(),
                Text = EmployeeType.Dispatcher.ToString()
            });


            EmployeeTitles.Add(new SelectListItem
            {
                Value = ((int)EmployeeType.Driver).ToString(),
                Text = EmployeeType.Driver.ToString()
            });

            EmployeeTitles.Add(new SelectListItem
            {
                Value = ((int)EmployeeType.Mechanic).ToString(),
                Text = EmployeeType.Mechanic.ToString()
            });

            EmployeeTitles.Add(new SelectListItem
            {
                Value = ((int)EmployeeType.Recruiter).ToString(),
                Text = EmployeeType.Recruiter.ToString()
            });

            EmployeeTitles.Add(new SelectListItem
            {
                Value = ((int)EmployeeType.MechanicManger).ToString(),
                Text = EmployeeType.MechanicManger.ToString()
            });


            TodaysDate = DateTime.Now.ToShortDateString();


        }


    }
}
