// See https://aka.ms/new-console-template for more information
using System;

namespace Billy
{
    class Program
    {
        public static void Main()
        {
            Client client = new Client();
            client.AddIndustrial(0, "Ford Focus RS", 4000, "Bad", 2015, "Sedan", "Ford");
            client.AddIndustrial(1, "Ford Mustang", 5000, "Good", 2015, "Sedan", "Ford");
            client.AddPassenger(2, "Tesla Roadster", 3000, "OK", 2020, "Sedan", "Tesla");

            Command cli = new Command(client);
            cli.Start();
        } 
    }
    
}