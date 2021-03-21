using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
   static class IDChecker
    {
        public static void ChekID(List<IRobot> robots, string id)
        {
            foreach (var item in robots)
            {
                if (item.Id.EndsWith(id))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
        public static void ChekIDCitizens(List<ICitizen> citizens, string id)
        {
            foreach (var item in citizens)
            {
                if (item.Id.EndsWith(id))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}
