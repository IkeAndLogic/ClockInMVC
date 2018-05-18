using ClockInMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClockInMVC.Models;
using Microsoft.AspNetCore.Mvc;
using ClockInMVC.Data;

namespace ClockInMVC.Controllers
{

    public class TractorController : Controller
    {



        // a private ClockInDBContext object that will be used within the class to interface with the database

        private readonly ClockInDbContext context;

        // create a constructor that takes the TracktorDbContext object as a parameter
        // so that you can have access to the class in the framework(from the "startup.cs" file)


         





        public TractorController(ClockInDbContext dbContext)
        {
           context = dbContext;
        }
        



        // GET: /<controller>/
        public IActionResult Index()
            {
                List<Tractor> tractors = context.Tractors.ToList();

            return View(tractors);
            }


            //gets details for individual trailer mapped by id
            public IActionResult TractorInfo(int id)
            {
            Tractor tractorinfo = context.Tractors.Single(e => e.TractorID == id);

                return View(tractorinfo);
            }


        // httpGet
            public IActionResult Add()
            {
                AddTractorViewModel addtractorViewModel = new AddTractorViewModel();

                return View(addtractorViewModel);
            }

            [HttpPost]
            public IActionResult Add(AddTractorViewModel addtractorViewModel)
            {
                if (ModelState.IsValid)
                {
                    Tractor newTractor = new Tractor
                    {
                        VinNumber = addtractorViewModel.VinNumber,
                        Make = addtractorViewModel.Make,
                        Model = addtractorViewModel.Model,
                        DotInp = addtractorViewModel.DotInp,
                        Plate = addtractorViewModel.Plate,
                        TruckNumber = addtractorViewModel.TruckNumber,
                        RegDate = addtractorViewModel.RegDate,
                        Year = addtractorViewModel.Year


                    };

                    //add to tractorData
                    context.Tractors.Add(newTractor);
                //always save changes
                context.SaveChanges();

                return Redirect("/Tractor");
                };
                return View(addtractorViewModel);

            }


        public IActionResult Remove()
        {
            RemoveTractorViewModel removeTractorViewModel = new RemoveTractorViewModel(context.Tractors.ToList());

            return View(removeTractorViewModel);

        }


        [HttpPost]
        public IActionResult Remove(int[] tractorIds)
        {
            foreach (int tractorId in tractorIds)
            {

                Tractor removeTractor = context.Tractors.Single(c => c.TractorID == tractorId);

                context.Tractors.Remove(removeTractor);

            }

            context.SaveChanges();
            return Redirect("/");
        }

    }


}

