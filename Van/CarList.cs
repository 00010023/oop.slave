using System;
using System.Collections.Generic;
using System.Linq;

namespace Van
{
    public class CarList
    {
        private static List<Car> Car = new List<Car>();

        public void AddCar(Car car)
        {
            Car.Add(car);
            Console.WriteLine("Adding the car: " + car);
        }
        
        public List<Car> GetAllCars()
        {
            return Car;
        }
        
        public List<Car> GetIndustrialCars()
        {
            List<Car> industrialCars = new List<Car>();
            foreach (Car car in Car)
            {
                if (car.GetCarType() == "Industrial")
                {
                    industrialCars.Add(car);
                }
            }
            return industrialCars;
        }
        
        public List<Car> GetPassengerCars()
        {
            List<Car> passengerCars = new List<Car>();
            foreach (Car car in Car)
            {
                if (car.GetCarType() == "Passenger")
                {
                    passengerCars.Add(car);
                }
            }
            return passengerCars;
        }
        
        public List<Car> GetCarsByModel(string model)
        {
            List<Car> carsByModel = new List<Car>();
            foreach (Car car in Car)
            {
                if (car.GetCarModel() == model)
                {
                    carsByModel.Add(car);
                }
            }
            return carsByModel;
        }

        public List<Car> GetCarsByArguments(string model = "", string industry = "")
        {
            if (string.IsNullOrWhiteSpace(model) && !string.IsNullOrWhiteSpace(industry))
            {
                switch (industry)
                {
                    case "Passenger":
                    case "passenger":
                        return GetPassengerCars();
                    case "Industrial":
                    case "industrial":
                        return GetIndustrialCars();
                    default:
                        return GetAllCars();
                }
            }
            else if (!string.IsNullOrWhiteSpace(model) && string.IsNullOrWhiteSpace(industry))
            {
                return GetCarsByModel(model);
            }
            else if (!string.IsNullOrWhiteSpace(model) && !string.IsNullOrWhiteSpace(industry))
            {
                List<Car> carsByModel = GetCarsByModel(model);
                List<Car> carsByIndustry = new List<Car>();
        
                if (industry == "Passenger")
                {
                    foreach (Car car in carsByModel)
                    {
                        if (car.GetCarType() == "Passenger")
                        {
                            carsByIndustry.Add(car);
                        }
                    }
                }
                else
                {
                    foreach (Car car in carsByModel)
                    {
                        if (car.GetCarType() == "Industrial")
                        {
                            carsByIndustry.Add(car);
                        }
                    }
                }
                
                return carsByModel.Intersect(carsByIndustry).ToList();
            }
            else
            {
                return GetAllCars();
            }
        }
        
        public void DisplayCars()
        {
            foreach (Car car in Car)
            {
                Console.WriteLine(car.ToString());
            }
        }

    }
}