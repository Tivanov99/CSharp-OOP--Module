using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private ICommand command;
        private CoomandCreator commandCreator;
        public CommandInterpreter()
        {
            commandCreator = new CoomandCreator();
        }
        public string Read(string args)
        {
            command = commandCreator.CreateCommand(args.Split()[0]);
            return command.Execute(args.Split());
        }
    }
}
