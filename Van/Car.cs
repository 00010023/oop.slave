using System;

namespace Van
{
    public class Car
    {
        private string id { get; }
        private string type { get; }
        private float price { get; }
        private string model { get; }
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

        public string GetType()
        {
            return this.type;
        }
        
        public string GetModel()
        {
            return this.model;
        }
        
        public override string ToString()
        {
            return $"{id} | {price.ToString()} | {model} | {condition} | {year.ToString()}";
        }
    }
}