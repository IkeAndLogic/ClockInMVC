using ClockInMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.ViewModels
{
    public class RemoveEmployeeViewModel
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public List<Employee> Employees { get; set; }
        //public int ID { get; set; }



        public RemoveEmployeeViewModel(List<Employee> employees)
        {
            Employees = employees;
        }
    }


}
