using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Birthday : IBirthday
    {
        private string day;
        private string mounth;
        private string year;
        public Birthday(string day, string mounth, string year)
        {
            Day = day;
            Mounth = mounth;
            Year = year;
        }
        public string Day
        {
            get => this.day;
            private set => this.day = value;
        }

        public string Mounth
        {
            get => this.mounth;
            private set => this.mounth = value;
        }
        public string Year
        {
            get => this.year;
            private set => this.year = value;
        }
        public string ReturnYear()
        {
            return this.Year;
        }
        public override string ToString()
        {
            return $"{this.Day}/{this.Mounth}/{this.Year}";
        }
    }
}
