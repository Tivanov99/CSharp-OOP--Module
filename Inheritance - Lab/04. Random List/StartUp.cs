using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList random = new RandomList();
            Console.WriteLine(random.RandomString(new List<string> { "vladi", "gogo", "rali" }));

        }
    }
}
