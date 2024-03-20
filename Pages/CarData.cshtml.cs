using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AKY_Motors_Assignment2.Models;
using AKY_Motors_Assignment2.Services;
using System.Collections.Generic;

namespace AKY_Motors_Assignment2.Pages
{
    // PageModel class responsible for handling the CarData page
    public class CarDataModel : PageModel
    {
        private readonly JsonCarService _jsonCarService; // Service for handling JSON data

        // Constructor for initializing the CarDataModel with required dependencies
        public CarDataModel(JsonCarService jsonCarService)
        {
            _jsonCarService = jsonCarService; // Inject JsonCarService dependency
        }

        public List<Car> Cars { get; private set; } // List to hold car data retrieved from JSON

        // Method executed when the page is requested
        public void OnGet()
        {
            // Retrieve list of cars from the JsonCarService
            Cars = _jsonCarService.GetCars();
        }
    }
}
