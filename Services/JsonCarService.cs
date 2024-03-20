using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using AKY_Motors_Assignment2.Models;

namespace AKY_Motors_Assignment2.Services
{
    // Service class responsible for retrieving car data from a JSON file.
    public class JsonCarService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        // Initializes a new instance of the JsonCarService class.
        public JsonCarService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        // Retrieves a list of car objects from the JSON file.
        public List<Car> GetCars()
        {
            // Construct the file path to the JSON file containing car data.
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "data", "cars.json");

            // Read the contents of the JSON file.
            var json = File.ReadAllText(filePath);

            // Deserialize the JSON string into a list of Car objects.
            return JsonConvert.DeserializeObject<List<Car>>(json);
        }
    }
}
