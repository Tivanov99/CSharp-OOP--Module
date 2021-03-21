using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> products;
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }
        public string Name
        {
            get => this.name;
            private set
            {
                Validations.ThrowsIfNameIsInvalid(value);
                this.name = value;
            }
        }
        public double Money
        {
            get => this.money;
            private set
            {
                Validations.ThrowIfMoneyIsNegative(value);
                this.money = value;
            }
        }
        public void AddProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
                return;
            }
            Console.WriteLine($"{this.Name} bought {product.Name}");
                this.money -= product.Cost;
            products.Add(product);
        }
        public override string ToString()
        {
            return $"{this.Name} - {string.Join(", ", products)}";
        }
        public void GetProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine($"{this.Name} - Nothing bought");
                return;
            }
            Console.WriteLine($"{this.Name} - {string.Join(", ",products.Select(p=>p.Name))}");
        }
    }
}
