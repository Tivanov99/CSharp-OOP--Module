using System;
using System.Collections.Generic;
using System.Text;

namespace NeedforSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsepower, double fuel)
            : base(horsepower, fuel)
        {
            base.DefaultFuelConsumption = 10;
        }
    }
}
