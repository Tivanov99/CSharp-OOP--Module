using Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car : ICar
    {
        private string model;
        private string color;
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Model
        {
            get => this.model;
            private set
            {
                this.model = value;
            }
        }

        public string Color
        {
            get => this.color;
            private set
            {
                this.color = value;
            }
        }

        public string Start()
        {
            return "Breaaak!";
        }

        public string Stop()
        {
            throw new NotImplementedException();
        }
        
    }
}
