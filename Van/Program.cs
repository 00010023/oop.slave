using System;

namespace Van
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to the Car Dealership!");

            CarList cars = new CarList();
            cars.AddCar(0, "Passenger", 10000, "Ford Focus Zetec Edition", "Chevrolet", "Excellent", 2000);
            cars.AddCar(1, "Passenger", 7000, "Nexia 3", "Chevrolet", "Good", 2019);
            cars.AddCar(2, "Industrial", 7000, "Citaro", "Mercedez", "Good", 2010);
            
            Console.WriteLine("Here is a list of our cars:");
            cars.DisplayCars();
            Console.Write("\n");
            
            Console.Write("What industry would you like to search: ");
            var searchInputIndustry = Console.ReadLine();
            
            Console.Write("What model would you like to search: ");
            var searchInputModel = Console.ReadLine();
            
            var search = cars.GetCarsByArguments(industry: searchInputIndustry, model: searchInputModel);
            Console.WriteLine("Here is a list of our cars matching your search:");
            foreach (var car in search)
            {
                Console.WriteLine(car);
            }
        }
    }
}