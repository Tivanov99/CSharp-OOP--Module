using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.AddRange(new List<string>{ "gogi","rali","trix"});
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
