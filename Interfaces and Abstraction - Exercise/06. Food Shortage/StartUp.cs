using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> Buyers = new Dictionary<string, IBuyer>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    string[] ParsetDates = DateParser(input);
                    Buyers.Add(input[0], new Citizen(input[0], int.Parse(input[1]), input[2], ParsetDates[0], ParsetDates[1], ParsetDates[2]));
                }
                else if (input.Length == 3)
                {
                    Buyers.Add(input[0], new Rebel(input[0], int.Parse(input[1]), input[2]));
                }
            }
            string Name = Console.ReadLine();
            while (Name != "End")
            {
                if (Buyers.ContainsKey(Name))
                {
                    Buyers[Name].BuyFood();
                }
                Name = Console.ReadLine();
            }
            Console.WriteLine(Buyers.Sum(x => x.Value.Food));

        }
        public static string[] DateParser(string[] dates)
        {
            string[] Splited = dates[dates.Length - 1].Split('/');
            return Splited;
        }
    }
}
