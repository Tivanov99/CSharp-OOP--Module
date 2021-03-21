using Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : Car, IElectricCar
    {
        private int battery;
        public Tesla(string model, string color, int battery)
            : base(model, color)
        {
            Battery = battery;
        }
        public int Battery
        {
            get => this.battery;
            private set
            {
                this.battery = value;
            }
        }
        public override string ToString()
        {
            return $"{this.Color} Tesla {this.Model} with {this.battery} Batteries";
        }
    }
}
