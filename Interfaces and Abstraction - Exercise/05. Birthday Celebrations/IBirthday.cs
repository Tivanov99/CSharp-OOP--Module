using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
   public interface IBirthday
    {
        public string Day { get; }
        public string Mounth { get; }
        public string Year { get; }
    }
}
