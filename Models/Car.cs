namespace AKY_Motors_Assignment2.Models
{
    // Represents a car with various attributes such as make, model, year, image, and price.
    public class Car
    {
        // Gets or sets the make of the car (e.g., Rolls Royce, Bugatti).
        public string Make { get; set; }

        // Gets or sets the model of the car (e.g., Wraith, Veyron).
        public string Model { get; set; }

        // Gets or sets the manufacturing year of the car.
        public int Year { get; set; }

        // Gets or sets the URL to the image of the car.
        public string Image { get; set; }

        // Gets or sets the price of the car in dollars.
        public int Price { get; set; }
    }
}
