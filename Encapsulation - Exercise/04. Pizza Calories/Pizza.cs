using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private List<Topping> toppings;
        private string name;
        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
        }
        public string Name
        {
            get => this.name;
            private set
            {
                try
                {
                    Validations.ChekForInvalidPizzaName(value);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                this.name = value;
            }
        }

        public Dough Dough { get; set; }
        public Topping Topping { get; set; }

        public void AddTopping(Topping topping)
        {
            try
            {
                Validations.ChekForInvalidCountOfToppings(toppings.Count);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            toppings.Add(topping);
        }
        public double TotalCallories()
        {
            return toppings.Sum(x => x.CalculateCaloriesPerGram())+Dough.CalloriesPerGram();
        }
    }
}
