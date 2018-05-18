using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.Models
{
    public class Trailer
    {
        public string SerialNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public DateTime DotInsp { get; set; }
        public DateTime RegDate { get; set; }
        public string Plate { get; set; }
        public string TrailerNumber { get; set; }
        public string  Status { get; set; }

        public int TrailerID { get; set; }

        public Trailer()
        {
            Status = "Avaliable";
        }

       
    }
}
