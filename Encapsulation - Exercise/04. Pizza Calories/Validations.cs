using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class Validations
    {
        public static void CheckWeightOFDough(double value)
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range[1..200].");
            }
        }
        public static void ChekForInvalidTechnique(string technique)
        {
            if (technique != "crispy" && technique != "chewy" && technique != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }
        public static void ChekForInvalidFlourType(string technique)
        {
            if (technique != "white" && technique != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }
        public static void ChekForInvalidToppingType(string topping)
        {
            string currValue = topping.ToLower();
            if (currValue != "meat" && currValue != "veggies" && currValue != "cheese" && currValue != "sauce")
            {
                throw new ArgumentException($"Cannot place {topping} on top of your pizza.");
            }
        }
        public static void ChekForInvalidToppingWeight(string topping, double value)
        {
            if (value < 1|| value > 50)
            {
                throw new ArgumentException($"{topping} weight should be in the range [1..50].");
            }
        }
        public static void ChekForInvalidPizzaName(string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length>15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
        }
        public static void ChekForInvalidCountOfToppings(int value)
        {
            if(value>10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }
    }
}
