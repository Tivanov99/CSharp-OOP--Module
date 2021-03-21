using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> Persons = new Dictionary<string, Person>();
            string[] Peoples = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] Products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Product> BagOFProducts = new Dictionary<string, Product>();
            foreach (var item in Peoples)
            {
                string[] current = item.Split('=', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                Persons.Add(current[0], new Person(current[0], double.Parse(current[1])));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            foreach (var products in Products)
            {
                string[] current = products.Split('=', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    BagOFProducts.Add(current[0], new Product(current[0], double.Parse(current[1])));

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "END")
                {
                    break;
                }
                Persons[command[0]].AddProduct(BagOFProducts[command[1]]);
            }
            foreach (Person item in Persons.Values)
            {
                item.GetProducts();
            }
        }
    }
}
