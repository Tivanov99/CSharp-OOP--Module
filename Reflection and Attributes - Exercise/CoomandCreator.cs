using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern
{
    public class CoomandCreator
    {
        public ICommand CreateCommand(string type)
        {
            Type types = Assembly.GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == $"{type}Command");

            if (types == null)
            {
                throw new ArgumentException($"{type} is invalid command type.");
            }

            ICommand instance = (ICommand)Activator.CreateInstance(types);

            return instance;
        }
    }
}
