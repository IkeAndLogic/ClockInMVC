using ClockInMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClockInMVC.Data
{
    public class ClockInDbContext : DbContext
    {

        // this DbSet will be used to interact with Employee/Driver/ database
        public DbSet<Employee> Employees { get; set; }

        //this DbSet will be used to interact with Tractor Database
        public DbSet<Tractor> Tractors { get; set; }

        //this DbSet will be used to interact with Tractor Database
        public DbSet<Trailer> Trailers { get; set; }

        // this DbSet will be used to interact with TractorDriver database
        public DbSet<TractorDriverLoad> DriverTractorLoad { get; set; }

        //this DbSet will be used to interact with DriverHistory database
        //public DbSet<TractorDriverHistory> DriveTractoryHistory { get; set; }

        // this DbSet will keep track of work day details for employees
        //public DbSet<EmployeeWorkDayData> EmployeeWorkDayDetails { get; set; }

        //this DbSet will be used to interact with Order Database
        public DbSet<Order> Orders { get; set; }

        public ClockInDbContext(DbContextOptions<ClockInDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TractorDriverLoad>().HasKey(t => new { t.EmployeeID, t.TractorID,t.OrderID });

            //builder.Entity<TractorDriverHistory>().HasKey(t => new { t.TractorDriverID, t.TractorID });

            //builder.Entity<EmployeeWorkDayData>().HasKey(t => new { t.EmployeeWorkDayID, t.EmployeeID});


        }



    }
}
