using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private double defaultCalloriesPerGram = 2;
        private string toppingType;
        private double weight;
        public Topping(string toppingType, double weight)
        {
            ToppingType = toppingType;
            Weight = weight;
        }
        public double Weight
        {
            get => this.weight;
            private set
            {
                try
                {
                    Validations.ChekForInvalidToppingWeight(this.toppingType, value);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);

                }
                this.weight = value;
            }
        }
        public string ToppingType
        {
            get => this.toppingType;
            private set
            {
                try
                {
                    Validations.ChekForInvalidToppingType(value);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                this.toppingType = value;
            }
        }
        public double CalculateCaloriesPerGram()
        {
            return this.weight *2* CheckToppingType(this.toppingType);
        }
        private double CheckToppingType(string type)
        {
            if (type.ToLower() == "meat")
            {
                defaultCalloriesPerGram = 1.2;
            }
            else if (type.ToLower() == "veggies")
            {
                defaultCalloriesPerGram = 0.8;
            }
            else if (type.ToLower() == "cheese")
            {
                defaultCalloriesPerGram = 1.1;
            }
            else if (type.ToLower() == "sauce")
            {
                defaultCalloriesPerGram = 0.9;
            }
            return defaultCalloriesPerGram;
        }
    }
}
