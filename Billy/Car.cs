using System;

namespace Billy
{
    public interface ICar
    {
        int Id { get; set; }
        string Model { get; set; }
        float Price { get; set; }
        string Condition { get; set; }
        int Year { get; set; }
        ICar GetCar();
    }
}