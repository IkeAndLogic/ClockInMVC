using ClockInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.ViewModels
{
    public class RemoveTractorViewModel
    {


        //public string Name { get; set; }
        //public string UserName { get; set; }
        public List<Tractor> Tractors { get; set; }



        public RemoveTractorViewModel(List<Tractor> tractors)
        {
            Tractors = tractors;
        }
    }
}

