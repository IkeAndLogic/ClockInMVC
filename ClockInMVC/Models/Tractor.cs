using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.Models
{
    public class Tractor
    {
        public string VinNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public DateTime DotInp { get; set; }
        public DateTime RegDate { get; set; }
        public string Plate { get; set; }
        public string TruckNumber { get; set; }



        public int TractorID { get; set; }

        public string Status { get; set; }

        public TractorDriverLoad DriverOfTractorLoad { get; set; }


        public Tractor()
        {
            Status = "Available";
        }
    }
}