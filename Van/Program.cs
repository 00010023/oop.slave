using System;

namespace Van
{
    class Program
    {
        private static void Main()
        {
            CarList cars = new CarList();
            cars.AddCar(0, "Passenger", 10000, "Ford Focus Zetec Edition", "Chevrolet", "Excellent", 2000);
            cars.AddCar(1, "Passenger", 7000, "Nexia 3", "Chevrolet", "Good", 2019);
            cars.AddCar(2, "Industrial", 7000, "Citaro", "Mercedez", "Good", 2010);
            
            Console.WriteLine("Welcome to the Car Dealership!");
            Console.WriteLine("Here is a list of our cars:");
            cars.DisplayCars();
            
            Console.WriteLine("\n");
            // The moment of truth my dear slaves!
            var search = cars.GetCarsByArguments(model: "Zetec");
            Console.WriteLine("Here is a list of our cars matching your search:");
            foreach (var car in search)
            {
                Console.WriteLine(car);
            }
            
            // YAY IT WORKS!!! UWU GANG RISE UP!!!
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("UwU UwU UwU UwU UwU UwU UwU");
            }
        }
    }
}