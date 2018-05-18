using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.Models
{
    public class TractorDriverHistory
    {
        public DateTime DateTimeAssigned { get; set; }
        public DateTime DateTimeReleased { get; set; }


        public int EmployeeID { get; set; }
        public int TractorID { get; set; }
        // public TractorDriver tractorDriver { get; set; }

    }
}
