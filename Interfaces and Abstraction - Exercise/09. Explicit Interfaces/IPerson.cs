using System;
using System.Collections.Generic;
using System.Text;

namespace _9
{
   public interface IPerson
    {
        public string Name { get; }
        public int Age { get; }
        string GetName();
    }
}
