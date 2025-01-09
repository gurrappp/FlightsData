using TCSA.WebAPIs.FlightsData.Data;
using TCSA.WebAPIs.FlightsData.Models;

namespace TCSA.WebAPIs.FlightsData.Services
{
    public interface IFlightService
    {
        public List<Flight> GetAllFlights();
        public Flight? GetFlightById(int id);
        public Flight CreateFlight(Flight flight);
        public Flight UpdateFlight(Flight updatedFlight);
        public string? DeleteFlight(int id);
    }

    public class FlightService : IFlightService
    {
        private readonly FlightsDbContext _dbContext;

        public FlightService(FlightsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Flight CreateFlight(Flight flight)
        {
            var savedFlight = _dbContext.Flights.Add(flight);
            _dbContext.SaveChanges();
            return savedFlight.Entity;
        }

        public string? DeleteFlight(int id)
        {
            var savedFlight = _dbContext.Flights.Find(id);
            
            if(savedFlight == null)
            {
                return null;
            }

            _dbContext.Remove(savedFlight);

            _dbContext.SaveChanges();

            return $"Successfully deleted flight with id: {id}";
        }

        public List<Flight> GetAllFlights()
        {
            return [.. _dbContext.Flights];
        }

        public Flight? GetFlightById(int id)
        {
            var flight = _dbContext.Flights.Find(id);

            return flight == null ? null : flight;
        }

        public Flight UpdateFlight(Flight flight)
        {
            var savedFlight = _dbContext.Flights.Find(flight.Id);

            if (savedFlight == null)
            {
                return null;
            }
            
            _dbContext.Entry(savedFlight).CurrentValues.SetValues(flight);
            _dbContext.SaveChanges();

            return savedFlight;
        
        }


    }
}
