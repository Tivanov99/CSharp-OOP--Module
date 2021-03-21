using System;
using System.Collections.Generic;
using System.Text;

namespace NeedforSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsepower, double fuel)
            : base(horsepower, fuel)
        {
            base.DefaultFuelConsumption = 3;
        }
    }
}
