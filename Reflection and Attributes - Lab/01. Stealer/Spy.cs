using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fielndsName)
        {
            Type typeClass = Type.GetType(className);

            FieldInfo[] fields = typeClass.GetFields(BindingFlags.Instance | BindingFlags.Static
                | BindingFlags.NonPublic | BindingFlags.Public);

            Console.WriteLine("END");
            StringBuilder sb = new StringBuilder();
            Object classInstance = Activator.CreateInstance(typeClass);
            sb.AppendLine($"Class under investigation: {className}");
            foreach (FieldInfo item in fields.Where(f => fielndsName.Contains(f.Name)))
            {
                sb.AppendLine($"{item.Name} = {item.GetValue(classInstance)}");
            }
            return sb.ToString().Trim();
        }
    }
}
