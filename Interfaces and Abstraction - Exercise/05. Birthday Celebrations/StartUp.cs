using System;
using System.Collections.Generic;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            List<IRobot> robots = new List<IRobot>();
            List<Pet> Pets = new List<Pet>();
            string[] input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                if (input[0] == "Citizen")
                {
                    string[] ParsetDates = DateParser(input);
                    citizens.Add(new Citizen(input[1], int.Parse(input[2]), input[3], ParsetDates[0], ParsetDates[1], ParsetDates[2]));
                }
                else if (input[0] == "Robot")
                {
                    robots.Add(new Robot(input[0], input[1]));
                }
                else if (input[0] == "Pet")
                {
                    string[] ParsetDates = DateParser(input);
                    Pets.Add(new Pet(input[1], ParsetDates[0], ParsetDates[1], ParsetDates[2]));
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            string Year = Console.ReadLine();
            IDChecker.CitizensBirthdate(citizens, Year);
            IDChecker.PetsBirthdays(Pets, Year);
        }
        public static string[] DateParser(string[] dates)
        {
            string[] Splited = dates[dates.Length - 1].Split('/');
            return Splited;
        }
    }
}
