using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Validations
    {
        public static void ThrowsIfNameIsInvalid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }
        public static void ThrowIfMoneyIsNegative(double price)
        {
            if(price<0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
        }
    }
}
