using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClockInMVC.Models;
using ClockInMVC.ViewModels;
using ClockInMVC.Data;
using ClockInMVC.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClockInMVC.Controllers
{
    public class TrailerController : Controller
    {



        // a private ClockInDBContext object that will be used within the class to interface with the database

        private readonly ClockInDbContext context;

        // create a constructor that takes the TrailerDbContext object as a parameter
        // so that you can have access to the class in the framework(from the "startup.cs" file)

        public TrailerController(ClockInDbContext dbContext)
        {
            context = dbContext;
        }




        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Trailer> trailers = context.Trailers.ToList();

            return View(trailers);

        }


        //displays form
        public IActionResult Add()
        {
            AddTrailerViewModel addtrailerViewModel = new AddTrailerViewModel();

            return View(addtrailerViewModel);
        }



        public IActionResult TrailerInfo(int id)
        {
            Trailer trailerinfo = context.Trailers.Single(t=> t.TrailerID == id);

            return View(trailerinfo);
        }



        [HttpPost]
        public IActionResult Add(AddTrailerViewModel addtrailerViewModel)
        {
            if (ModelState.IsValid)
            {
                Trailer newTrailer = new Trailer
                {
                    SerialNumber = addtrailerViewModel.SerialNumber,
                    Make = addtrailerViewModel.Make,
                    Model = addtrailerViewModel.Model,
                    DotInsp = addtrailerViewModel.DotInsp,
                    Plate = addtrailerViewModel.Plate,
                    RegDate = addtrailerViewModel.RegDate,
                    Year = addtrailerViewModel.Year,
                    TrailerNumber = addtrailerViewModel.TrailerNumber
                };

                //add to tractorData
                context.Trailers.Add(newTrailer);
                //always save changes
                context.SaveChanges();

                return Redirect("/Trailer");
            };
            return View(addtrailerViewModel);

        }






        public IActionResult Remove()
        {
            RemoveTrailerViewModel removeTrailerViewModel = new RemoveTrailerViewModel(context.Trailers.ToList());

            return View(removeTrailerViewModel);

        }


        [HttpPost]
        public IActionResult Remove(int[] trailerIds)
        {
            foreach (int trailerId in trailerIds)
            {

                Trailer removeTrailer = context.Trailers.Single(c => c.TrailerID == trailerId);

                context.Trailers.Remove(removeTrailer);

            }

            context.SaveChanges();
            return Redirect("/");
        }

    }
}
