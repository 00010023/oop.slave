namespace Billy
{
    public class Passenger : ICar
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public string Condition { get; set; }
        public int Year { get; set; }
        private string Type { get; } 
        private string Brand { get; }
        
        public Passenger(int id, string model, float price, string condition, int year, string type, string brand)
        {
            Id = id;
            Model = model;
            Price = price;
            Condition = condition;
            Year = year;
            Type = type;
            Brand = brand;
        }
        
        public ICar GetCar()
        {
            return this;
        }

        public string GetModel()
        {
            return Model;
        }
        
        public override string ToString()
        {
            return $"{Id.ToString()}\t{Model}\t{Price.ToString("C")}\t{Condition}\t{Year.ToString()}\t{Type}\t{Brand}";
        }
    }
}