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
        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            MethodInfo[] publicMethoods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] privateMethoods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (FieldInfo item in fields)
            {
                sb.AppendLine($"{item.Name} must be private!");
            }
            foreach (MethodInfo item in privateMethoods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{item.Name} have to be public!");
            }
            foreach (MethodInfo item in publicMethoods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{item.Name} have to be private!");
            }
            return sb.ToString().Trim();
        }
        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();
            Type classType = Type.GetType(className);
            MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (MethodInfo item in methods.Where(x=>x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{item.Name} will return {item.ReturnType}");
            }
            foreach (MethodInfo item in methods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{item.Name} will set field of {item.GetParameters().First().ParameterType}");
            }
            return sb.ToString().Trim();
        }
    }
}
