using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.ViewModels
{
    public class AddTractorViewModel
    {
        [Required(ErrorMessage = "You must provide the vin number")]
        public string VinNumber { get; set; }

        [Required(ErrorMessage = "You must provide the make of the vehicle")]
        public string Make { get; set; }

        [Required(ErrorMessage = "You must provide the model of the vehicle")]
        public string Model { get; set; }

        [Required(ErrorMessage = "You must provide the year of the vehicle")]
        public string Year { get; set; }

        [Required(ErrorMessage = "You must provide the D.O.T inspection date")]
        [DataType(DataType.Date)]
        public DateTime DotInp { get; set; }

        [Required(ErrorMessage = "You must provide the vehicle registration date")]
        [DataType(DataType.Date)]
        public DateTime RegDate { get; set; }

        [Required(ErrorMessage = "You must provide the Plate number")]
        public string Plate { get; set; }

        [Required(ErrorMessage = "You must assign a Truck number")]
        public string TruckNumber { get; set; }

        public string TodaysDate { get; set; }


        public AddTractorViewModel()
        {
            TodaysDate = DateTime.Now.ToShortDateString();
        }

    }
}

