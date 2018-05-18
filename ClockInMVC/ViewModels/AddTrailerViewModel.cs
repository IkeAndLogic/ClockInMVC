using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.ViewModels
{
    public class AddTrailerViewModel
    {
        [Required(ErrorMessage = "You must provide the vin number")]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "You must provide the make of the vehicle")]
        public string Make { get; set; }

        [Required(ErrorMessage = "You must provide the model of the vehicle")]
        public string Model { get; set; }

        [Required(ErrorMessage = "You must provide the year of the vehicle")]
        public string Year { get; set; }

        [Required(ErrorMessage = "You must provide the D.O.T inspection date")]
        [DataType(DataType.Date)]
        public DateTime DotInsp { get; set; }

        [Required(ErrorMessage = "You must provide the vehicle registration date")]
        [DataType(DataType.Date)]
        public DateTime RegDate { get; set; }

        [Required(ErrorMessage = "You must provide the Plate number")]
        public string Plate { get; set; }

        [Required(ErrorMessage = "You must assign a Trailer number")]
        public string TrailerNumber { get; set; }

        public string TodaysDate { get; set; }

        public AddTrailerViewModel()
        {
            TodaysDate = DateTime.Now.ToShortDateString();
        }

    }


}
