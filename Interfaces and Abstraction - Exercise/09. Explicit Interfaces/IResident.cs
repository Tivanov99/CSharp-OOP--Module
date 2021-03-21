using System;
using System.Collections.Generic;
using System.Text;

namespace _9
{
  public  interface IResident
    {
        public string Name { get; }
        public string Country { get;  }
        string GetName();
    }
}
