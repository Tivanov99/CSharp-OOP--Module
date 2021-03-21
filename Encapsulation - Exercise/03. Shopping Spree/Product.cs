using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private double cost;
        private string name;

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
        public double Cost
        {
            get => this.cost;
            private set
            {
                Validations.ThrowIfMoneyIsNegative(value);
                this.cost = value;
            }
        }
        public string Name
        {
            get => this.name;
            private set
            {
                try
                {
                    Validations.ThrowsIfNameIsInvalid(value);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                this.name = value;
            }
        }

    }
}
