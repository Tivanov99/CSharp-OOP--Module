using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Pet : Birthday, IPet
    {
        private string name;
        public Pet(string name, string day, string mounth, string year)
            : base(day, mounth, year)
        {
            Name = name;
        }
        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }

    }
}
