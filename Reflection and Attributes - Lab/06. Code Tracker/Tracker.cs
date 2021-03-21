using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (MethodInfo item in methods)
            {
                if (item.CustomAttributes.Any(n => n.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = item.GetCustomAttributes(false);
                    foreach (AuthorAttribute att in attributes)
                    {
                        Console.WriteLine($"{item.Name} is written by {att.Name}");
                    }
                }
            }
        }
    }
}
