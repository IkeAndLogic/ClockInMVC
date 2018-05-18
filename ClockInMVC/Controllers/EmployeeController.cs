using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClockInMVC.Data;
using ClockInMVC.Models;
using ClockInMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ClockInMVC.Controllers
{
    public class EmployeeController : Controller
    {



        // a private EpmloyeeDBContext object that will be used within the class to interface with the database
        private readonly ClockInDbContext context;

        // create a constructor that takes the EmployeeDbContext object as a parameter
        // so that you can have access to the class in the framework(from the "startup.cs" file)
        public EmployeeController(ClockInDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            //List of employee pulled from the Employee DbSet from the ClockinDbContext
            List<Employee> employees = context.Employees.ToList();

            return View(employees);
        }



        public IActionResult Add()
        {
            AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel();

            return View(addEmployeeViewModel);
        }


        //gets details for individual employee mapped by id
        public IActionResult EmployeeInfo(int id)
        {
            Employee employeeInfo = context.Employees.Single(e => e.EmployeeID == id);

            return View(employeeInfo);
        }




        [HttpPost]
        public IActionResult Add(AddEmployeeViewModel addEmployeeViewModel)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = new Employee()
                {

                    FirstName = addEmployeeViewModel.FirstName,
                    MiddleName = addEmployeeViewModel.MiddleName,
                    LastName = addEmployeeViewModel.LastName,

                    SSN = addEmployeeViewModel.SSN,
                    SsnConfirm = addEmployeeViewModel.SsnConfirm,

                    Dob = addEmployeeViewModel.Dob,

                    Title = addEmployeeViewModel.Title,

                    LicNumber = addEmployeeViewModel.LicNumber,
                    LicIssue = addEmployeeViewModel.LicIssue,
                    LicExpire = addEmployeeViewModel.LicExpire,

                    MedIssue = addEmployeeViewModel.MedIssue,
                    MedExpire = addEmployeeViewModel.MedExpire,

                    UserName = addEmployeeViewModel.UserName,
                    Password = addEmployeeViewModel.Password,
                    PasswordConf = addEmployeeViewModel.PasswordConf

                };


                //add to EmployeeData
                context.Employees.Add(newEmployee);
                //always save changes
                context.SaveChanges();

                return Redirect("/Employee");
            };
            return View(addEmployeeViewModel);

        }


        public IActionResult Remove()
        {
            RemoveEmployeeViewModel vm = new RemoveEmployeeViewModel(context.Employees.ToList());

            return View(vm);

        }


        [HttpPost]
        public IActionResult Remove(int[] employeeIds)
        {
            foreach (int employeeId in employeeIds)
            {

                Employee removeEmployee = context.Employees.Single(c => c.EmployeeID == employeeId);

                context.Employees.Remove(removeEmployee);

            }

            context.SaveChanges();
            return Redirect("/");
        }
    }


}

