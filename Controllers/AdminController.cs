using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace unitedones.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult EditPrisons() {

            return View();
        }
        
        public IActionResult ReviewDriver() {
            return View();
        }

        public IActionResult ReviewPayment() {
            return View();
        }

        public IActionResult ReviewRatings() {
            return View(); 
        }

        public IActionResult ReviewRider() {
            return View();
        }

        public IActionResult ReviewVehicle() {
            return View();
        }
        
        public IActionResult ViewAllTrips() {
            return View();
        }
    }
}