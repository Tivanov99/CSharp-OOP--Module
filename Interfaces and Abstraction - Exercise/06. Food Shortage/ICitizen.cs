using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface ICitizen
    {
        public string Id { get; }
        string Name { get; }
        int Age { get; }

    }
}
