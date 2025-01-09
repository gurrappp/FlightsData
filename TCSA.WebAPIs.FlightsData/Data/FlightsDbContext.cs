using Microsoft.EntityFrameworkCore;
using TCSA.WebAPIs.FlightsData.Models;

namespace TCSA.WebAPIs.FlightsData.Data
{
    public class FlightsDbContext : DbContext
    {
        public FlightsDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Flight> Flights { get; set; }
    }
}
