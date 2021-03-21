using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._Telephony
{
    public class Smartphone : ISmartphone
    {
        public string Browse(string url)
        {            
            return $"Browsing: {url}!";
        }

        public string Calling(string number)
        {
           
                return $"Calling... {number}";
           
        }
    }
}
