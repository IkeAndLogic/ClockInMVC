using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.Models
{
    public class TractorDriverLoad
    {
        //public Employee DriverOfTractor { get; set; }
        public int EmployeeID { get; set; }

        //public Tractor Tractor { get; set; }
        public int TractorID { get; set; }

       // public Order Order { get; set; }
        public int OrderID { get; set; }
    }
}
