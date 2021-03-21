using _3._Telephony;
using System;
using System.Linq;

namespace _3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
               .Split()
               .ToArray();
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            ISmartphone smartphone = new Smartphone();
            IStationaryPhone stationaryPhone = new StationaryPhone();
            foreach (string number in numbers)
            {
                bool isWrong = false;
                foreach (var item in number)
                {
                    if (!char.IsDigit(item))
                    {
                        isWrong = true;
                        Console.WriteLine("Invalid number!");
                        break;
                    }
                }
                if (!isWrong)
                {
                    if (number.Length == 10)
                    {
                        Console.WriteLine(smartphone.Calling(number));
                    }
                    else if (number.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Calling(number));
                    }
                }
            }
            foreach (var CurrURL in urls)
            {
                bool isFake = false;
                foreach (char CurrerntSite in CurrURL)
                {
                    if (char.IsDigit(CurrerntSite))
                    {
                        Console.WriteLine($"Invalid URL!");
                        isFake = true;
                        break;
                    }
                }
                if (!isFake)
                {
                    Console.WriteLine(smartphone.Browse(CurrURL));
                }
            }
        }
    }
}
