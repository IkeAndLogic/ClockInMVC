using ClockInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.ViewModel
{
    public class RemoveTrailerViewModel
    {

        //public string Name { get; set; }
        //public string UserName { get; set; }
        public List<Trailer> Trailers { get; set; }
        //public int ID { get; set; }



        public RemoveTrailerViewModel(List<Trailer> trailers)
        {
            Trailers = trailers;
        }
    }
}
