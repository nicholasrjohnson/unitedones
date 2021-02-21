using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace unitedones.Controllers
{
    public class DriverController : Controller
    {
        private readonly ILogger<DriverController> _logger;

        public DriverController(ILogger<DriverController> logger)
        {
            _logger = logger;
        }  

        public IActionResult AlterTrip() {
            return View();
        }

        public IActionResult ConfigurePreferences() {
            return View();
        }

        public IActionResult MakeTrip() {
            return View();
        }

        public IActionResult RateRider() {
            return View();
        }

        public IActionResult SetupVehicle() {
            return View();
        }

        public IActionResult ViewRatings() {
            return View();
        }

        public IActionResult ViewRider() {
            return View();
        }

        public IActionResult ViewRiderRating() {
            return View();
        }
    }
}