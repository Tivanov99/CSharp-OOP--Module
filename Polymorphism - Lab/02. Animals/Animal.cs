using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private string favouritefood;

        public Animal(string name, string favouritefood)
        {
            this.name = name;
            this.favouritefood = favouritefood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {name} and my fovourite food is {favouritefood}";
        }
    }
}
