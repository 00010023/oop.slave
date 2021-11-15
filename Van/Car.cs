using System;

namespace Van
{
    public class Car
    {
        private string id { get; }
        public string type { get; }
        private float price { get; }
        public string model { get; }
        private string brand { get; }
        private string condition { get; }
        private int year { get; }
        
        public Car(string id, string type, float price, string model, string brand, string condition, int year)
        {
            this.id = id;
            this.type = type;
            this.price = price;
            this.model = model;
            this.brand = brand;
            this.condition = condition;
            this.year = year;
        }

        public Car GetCar()
        {
            return this;
        }
        
        public override string ToString()
        {
            return $"{id} | {price.ToString()} | {model} | {condition} | {year.ToString()}";
        }
    }
}