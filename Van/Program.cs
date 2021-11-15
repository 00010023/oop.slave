using System;

namespace Van
{
    class Program
    {
        static void Main(string[] args)
        {
            CarList cars = new CarList();
            cars.AddCar(new Car("Ford", "Passenger", 10000, "Zetec Edition", "Chevrolet", "Excellent", 2000));
            cars.AddCar(new Car("Nexia", "Passenger", 7000, "3/4", "Chevrolet", "Good", 2019));
            cars.AddCar(new Car("Lada", "Industrial", 7000, "3/4", "Chevrolet", "Good", 2019));
            
            Console.WriteLine("Welcome to the Car Dealership!");
            Console.WriteLine("Here is a list of our cars:");
            cars.DisplayCars();
            
            Console.WriteLine("\n");
            // The moment of truth my dear slaves!
            var search = cars.GetCarsByArguments(industry: "Industrial");
            Console.WriteLine("Here is a list of our cars matching your search:");
            foreach (var car in search)
            {
                Console.WriteLine(car);
            }
        }
    }
}