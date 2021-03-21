using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter command)
        {
            commandInterpreter = command;
        }
        public void Run()
        {
            string input = Console.ReadLine();
            while (true)
            {
                string result = (commandInterpreter.Read(input));
                if (result == null)
                {
                    break;
                }
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
