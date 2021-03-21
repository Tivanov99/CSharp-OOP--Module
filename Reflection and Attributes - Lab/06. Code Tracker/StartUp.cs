using System;
using System.Reflection;

namespace AuthorProblem
{
    [Author("rali")]
    public class StartUp
    {
        [Author("trix")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
