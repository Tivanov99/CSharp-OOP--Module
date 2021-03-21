using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            Console.WriteLine(spy.AnalyzeAccessModifiers("Stealer.Hacker"));

            Hacker hacker = new Hacker();
        }
    }
}
