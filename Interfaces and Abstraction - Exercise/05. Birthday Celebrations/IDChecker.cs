using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    static class IDChecker
    {
        public static void CitizensBirthdate(List<Citizen> citizens, string year)
        {
            foreach (var item in citizens)
            {
                if (item.ReturnYear() == year)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public static void PetsBirthdays(List<Pet> pets, string year)
        {
            foreach (var item in pets)
            {
                if (item.Year == year)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
