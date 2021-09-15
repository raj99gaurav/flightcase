using FlightServiceAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightServiceAPI.Context
{
    public class FlightSerDb : DbContext
    {
        public FlightSerDb(DbContextOptions<FlightSerDb> options) : base(options)
        {

        }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Flight> Flights { get; set; }
    }
}
