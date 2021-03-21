using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Mammal : Animal
    {
        public String Name { get; set; }
        public Mammal(string name)
            : base(name)
        {
            this.Name = name;
        }
    }
}
