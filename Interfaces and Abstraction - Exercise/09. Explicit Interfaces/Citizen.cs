using System;
using System.Collections.Generic;
using System.Text;

namespace _9
{
    public class Citizen : IPerson, IResident
    {
        private string name;
        private string country;
        private int age;
        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                this.name = value;
            }
        }

        public string Country
        {
            get => this.country;
            private set => this.country = value;
        }

        public int Age
        {
            get => this.age;
            private set => this.age = value;
        }

        public string GetName()
        {
            return $"{this.name}";
        }

        string IResident.GetName()
        {
            GetName();
            return $"Mr/Ms/Mrs {this.name}";
        }


    }
}
