using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace unitedones.Controllers
{
    public class RiderController : Controller
    {
        private readonly ILogger<RiderController> _logger;

        public RiderController(ILogger<RiderController> logger)
        {
            _logger = logger;
        } 

        public IActionResult ConfigurePreferences() {
            return View();
        }

        public IActionResult RateDriver()  {
            return View();
        }

        public IActionResult SelectTrip() {
            return View();
        }

        public IActionResult ViewDriver() {
            return View();
        }

        public IActionResult ViewDriverRating() {
            return View();           
        }

        public IActionResult ViewRatings() {
            return View();
        }
    }
}