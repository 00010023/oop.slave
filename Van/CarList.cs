using System;
using System.Collections.Generic;
using System.Linq;

namespace Van
{
    public class CarList
    {
        private static List<Car> Car = new List<Car>();

        public void AddCar(int id, string type, float price, string model, string brand, string condition, int year)
        {
            Car.Add(new Car( id,  type,  price,  model,  brand,  condition,  year));
            Console.WriteLine("Adding the car: " + model);
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
        
        public List<Car> SearchCarsByModel(string model)
        {
            List<Car> carsByModel = new List<Car>();
            foreach (Car car in Car)
            {
                if (car.GetCarModel().Contains(model))
                {
                    carsByModel.Add(car);
                }
            }
            return carsByModel;
        }

        public List<Car> SearchCarsByIndustry(string industry)
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

        public List<Car> GetCarsByArguments(string model = "", string industry = "")
        {
            if (string.IsNullOrWhiteSpace(model) && !string.IsNullOrWhiteSpace(industry))
            {
                return SearchCarsByIndustry(industry);
            }
            else if (!string.IsNullOrWhiteSpace(model) && string.IsNullOrWhiteSpace(industry))
            {
                return SearchCarsByModel(model);
            }
            else if (!string.IsNullOrWhiteSpace(model) && !string.IsNullOrWhiteSpace(industry))
            {
                return SearchCarsByModel(model).Intersect(SearchCarsByIndustry(industry)).ToList();
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