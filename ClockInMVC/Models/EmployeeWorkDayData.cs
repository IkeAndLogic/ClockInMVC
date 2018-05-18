using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.Models
{
    public class EmployeeWorkDayData
    {

        public int EmployeeWorkDayID { get; set; }

        public int EmployeeID { get; set; }

        //stores hours worked
        public int WorkDayhours { get; set; }

        //stores hours worked
        public int WorkWeekHours { get; set; }

        //to store time in and out
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }

        public List<Tractor> Tractors { get; set; }
        public DateTime TractorAssignment { get; set; }
        public DateTime TractorRelease { get; set; }

        /*public List<Load> Load{get;set}
        public DateTime LoadAssignment { get; set; }
        public DateTime LoadCompleted { get; set; }
        public DateTime LoadCanceled { get; set; }
        */

        /*public List<Trailer> Trailer{get;set}
        public DateTime TrailerAssignment { get; set; }
        public DateTime TrailerRelease { get; set; }
        */
    }
}
