using System;
using System.Collections.Generic;
using System.Linq;

namespace Billy
{
    public class Client
    {
        private List<Industrial> industrials = new List<Industrial>();
        private List<Passenger> passengers = new List<Passenger>();
        
        public void AddIndustrial(int id, string model, float price, string condition, int year, string type, string brand)
        {
            industrials.Add(new Industrial(id, model, price, condition, year, type, brand));
        }
        
        public void AddPassenger(int id, string model, float price, string condition, int year, string type, string brand)
        {
            passengers.Add(new Passenger(id, model, price, condition, year, type, brand));
        }
        
        private List<ICar> GetIndustrials()
        {
            return industrials.Cast<ICar>().ToList();
        }
        
        private List<ICar> GetPassengers()
        {
            return passengers.Cast<ICar>().ToList();
        }

        private List<ICar> SearchByIndustry(string industry)
        {
            switch (industry)
            {
                case "Passenger":
                case "passenger":
                    return GetPassengers();
                case "Industrial":
                case "industrial":
                    return GetIndustrials();
                default:
                    return GetAllCars();
            }
        }

        private List<ICar> SearchByModel (string model)
        {
            List<ICar> result = new List<ICar>();
            foreach (var industrial in industrials)
            {
                if (industrial.GetModel().Contains(model))
                {
                    result.Add(industrial.GetCar());
                }
            }
            foreach (var passanger in passengers)
            {
                if (passanger.GetModel().Contains(model))
                {
                    result.Add(passanger.GetCar());
                }
            }
            return result;
        }

        public List<ICar> GetAllCars()
        {
            List<ICar> cars = new List<ICar>();
            foreach (var industrial in industrials)
            {
                cars.Add(industrial.GetCar());
            }
            foreach (var passenger in passengers)
            {
                cars.Add(passenger.GetCar());
            }
            return cars;
        }
        
        public List<ICar> Search(string model = "", string industry = "")
        {
            if (string.IsNullOrWhiteSpace(model) && !string.IsNullOrWhiteSpace(industry))
            {
                return SearchByIndustry(industry);
            }
            else if (!string.IsNullOrWhiteSpace(model) && string.IsNullOrWhiteSpace(industry))
            {
                return SearchByModel(model);
            }
            else if (!string.IsNullOrWhiteSpace(model) && !string.IsNullOrWhiteSpace(industry))
            {
                return SearchByModel(model).Intersect(SearchByIndustry(industry)).ToList();
            }
            else
            {
                return GetAllCars();
            }
        }
    }
}