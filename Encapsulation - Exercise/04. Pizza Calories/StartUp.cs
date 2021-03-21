using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] pizzaInput = Console.ReadLine().Split();
            string[] input = Console.ReadLine().Split();

            Dough dough = new Dough(input[1], input[2], double.Parse(input[3]));
            Pizza pizza = new Pizza(pizzaInput[1], dough);
            while (true)
            {
                input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }
                else
                {
                    Topping topping = new Topping(input[1], double.Parse(input[2]));
                    pizza.AddTopping(topping);
                }
            }
            Console.WriteLine($"{pizza.Name} - {pizza.TotalCallories():F2} Calories.");
        }
    }
}
