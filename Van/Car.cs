using System;

namespace Van
{
    public class Car
    {
        public string id { get; set; }
        public string type { get; set; }
        public float price { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public string condition { get; set; }
        public int year { get; set; }
        
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

        public override string ToString()
        {
            return $"{id} | {price.ToString()} | {model} | {condition} | {year.ToString()}";
        }
    }
}