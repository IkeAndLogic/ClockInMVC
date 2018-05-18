using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.Models
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public string Customer { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime TimeDue { get; set; }

        //mark available or Completed
        public string OrderStatus { get; set; }

        //needs to be a Trailer object to assign load to Trailer by trailer number
        public Trailer TrailerForLoad { get; set; }

        public Employee EmployeeName { get; set; }

        // mark as live load or drop and hook
        public string LoadPlan { get; set; }

        //holds the id of individual loads
        public int OrderID { get; set; }

        public TractorDriverLoad DriverTractorLoad { get; set; }


       
    }
}
