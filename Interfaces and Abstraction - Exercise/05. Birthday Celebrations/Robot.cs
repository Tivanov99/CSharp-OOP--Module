using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Robot : IRobot
    {
        private string id;
        private string model;

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
        public string Id
        {
            get => this.id;
            private set => this.id = value;
        }

        public string Model
        {
            get => this.model;
            private set => this.model = value;
        }
    }
}
