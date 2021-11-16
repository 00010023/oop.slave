using System;

namespace Van
{
    public class Car
    {
        private int Id { get; }
        private string Type { get; }
        private float Price { get; }
        private string Model { get; }
        private string Brand { get; }
        private string Condition { get; }
        private int Year { get; }
        
        public Car(int id, string type, float price, string model, string brand, string condition, int year)
        {
            this.Id = id;
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.Brand = brand;
            this.Condition = condition;
            this.Year = year;
        }

        public string GetCarType()
        {
            return this.Type;
        }
        
        public string GetCarModel()
        {
            return this.Model;
        }

        public override string ToString()
        {
            return $"{Id.ToString()} | {Price.ToString("C")} | {Model} | {Condition} | {Brand} |{Year.ToString()}";
        }
    }
}