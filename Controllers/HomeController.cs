using Microsoft.AspNetCore.Mvc;
using AKY_Motors_Assignment2.Services;

namespace AKY_Motors_Assignment2.Controllers
{
    // Controller class responsible for handling requests related to the home page and car data.
    public class HomeController : Controller
    {
        private readonly JsonCarService _jsonCarService;

        // Initializes a new instance of the HomeController class.
        public HomeController(JsonCarService jsonCarService)
        {
            _jsonCarService = jsonCarService;
        }

        // Action method for rendering the home page view.
        public IActionResult Index()
        {
            return View();
        }

        // Action method for rendering the car data view, which displays information about available cars.
        public IActionResult CarData()
        {
            // Retrieve the list of cars from the JsonCarService.
            var cars = _jsonCarService.GetCars();
            return View(cars);
        }

        // Action method for rendering the about view, which provides information about the application.
        public IActionResult About()
        {
            return View();
        }
    }
}
