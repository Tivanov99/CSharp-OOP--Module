using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : Birthday, ICitizen
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        public Citizen(string name, int age, string id, string day, string mounth, string year)
            : base(day, mounth, year)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;
        }
        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }

        public int Age
        {
            get => this.age;
            private set => this.age = value;
        }
        public string Id
        {
            get => this.id;
            private set => this.id = value;
        }

        public string BirthDate
        {
            get => this.birthdate;
            private set => this.birthdate = value;
        }
        
    }
}
