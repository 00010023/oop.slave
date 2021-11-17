using System;
using System.Collections.Generic;

namespace Billy
{
    public class Command
    {
        private Client Client = new Client();
        private string IndustryChoice { get; set; }
        private string ModelInput { get; set; }

        public Command(Client client)
        {
            this.Client = client;
        }
        
        private void SetIndustryChoice(string industryChoice)
        {
            this.IndustryChoice = industryChoice;
        }
        
        private void SetModelInput(string modelInput)
        {
            this.ModelInput = modelInput;
        }
        
        private void AskForModel()
        {
            Console.Write("Please enter the model of the car you want to buy: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                SetModelInput(input);
            }
            else
            {
                Console.WriteLine("You didn't enter anything, please try again");
                AskForModel();
            }
        }
        
        private void AskForIndustry()
        {
            Console.Write("Please enter the industry type of the car you want to buy: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                SetIndustryChoice(input);
            }
            else
            {
                Console.WriteLine("You didn't enter anything, please try again");
                AskForIndustry();
            }
        }
        
        private void ShowCars()
        {
            Console.WriteLine("Here are the cars we have in stock:");
            foreach (var car in Client.GetAllCars())
            {
                Console.WriteLine(car.ToString());
            }
        }
        
        private void ShowResult()
        {
            List<ICar> search = this.Client.Search(this.ModelInput, this.IndustryChoice);
            foreach (var result in search) 
            {
                Console.WriteLine(result.ToString());
            }
        }

        public void Start()
        {
            ShowCars();
            AskForIndustry();
            AskForModel();
            ShowResult();
        }
    }
}