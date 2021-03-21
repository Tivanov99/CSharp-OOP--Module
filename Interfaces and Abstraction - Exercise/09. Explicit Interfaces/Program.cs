using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0]!="End")
            {
                Citizen citizen = new Citizen(input[0],input[1],int.Parse(input[2]));
                IPerson person = citizen;
                IResident resident = citizen;
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
                
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
