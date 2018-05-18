using ClockInMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.ViewModels
{
    public class AddOrderViewModel
    {
        [Required(ErrorMessage = "Must Provide Order Number")]
        public string OrderNumber { get; set; }

        [Required(ErrorMessage = "Must Provide Customer Name")]
        public string Customer { get; set; }

        [Required(ErrorMessage = "Must Provide Street Number")]
        public string StreetNumber { get; set; }

        [Required(ErrorMessage = "Must Provide Street Name")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Must Provide City Name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Must Provide State Name")]
        public string State { get; set; }

        [Required(ErrorMessage = "Must Provide ZipCode")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Must Provide Due Date")]
        [DataType(DataType.Date)]
        public DateTime DateDue { get; set; }

        [Required(ErrorMessage = "Must Provide Time Due")]
        [DataType(DataType.Time)]
        public DateTime TimeDue { get; set; }

        [Required(ErrorMessage = "Must Provide delivery plan ")]
        public string LoadPlan { get; set; }

     

        public int TrailerID { get; set; }

        public List<SelectListItem> TrailersForLoad { get; set; }



        public AddOrderViewModel(IEnumerable<Trailer> trailersForLoad)
        {

            TrailersForLoad = new List<SelectListItem>();

            foreach (var trailer in trailersForLoad)

            {
                TrailersForLoad.Add(new SelectListItem

                {
                    Value = (trailer.TrailerID).ToString(),
                    Text = trailer.TrailerNumber
                });
            }







        }

    }
}
