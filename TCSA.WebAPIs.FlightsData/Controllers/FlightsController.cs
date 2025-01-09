using Microsoft.AspNetCore.Mvc;
using TCSA.WebAPIs.FlightsData.Models;
using TCSA.WebAPIs.FlightsData.Services;

namespace TCSA.WebAPIs.FlightsData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;
        public FlightsController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet]
        public ActionResult<List<Flight>> GetAllFlights()
        {
            return Ok(_flightService.GetAllFlights());
        }

        [HttpGet("{id}")]
        public ActionResult<Flight> GetFlightById(int id)
        {

            var result = _flightService.GetFlightById(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<Flight> CreateFlight(Flight flight)
        {
            return Ok(_flightService.CreateFlight(flight));
        }

        [HttpPut]
        public ActionResult<Flight> UpdateFlight(Flight updatedFlight)
        {
            var result = _flightService.UpdateFlight(updatedFlight);

            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<Flight> DeleteFlight(int id)
        {
            var result = _flightService.DeleteFlight(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
