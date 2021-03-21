using System;
using System.Collections.Generic;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<ICitizen> citizens = new List<ICitizen>();
            List<IRobot> robots = new List<IRobot>();
            string[] input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                if (input.Length == 3)
                {
                    citizens.Add(new Citizen(input[0], int.Parse(input[1]), input[2]));
                }
                else
                {
                    robots.Add(new Robot(input[0], input[1]));
                }
                input = Console.ReadLine().Split();
            }
            string number = Console.ReadLine();
            IDChecker.ChekID(robots, number);
            IDChecker.ChekIDCitizens(citizens, number);
        }
    }
}
