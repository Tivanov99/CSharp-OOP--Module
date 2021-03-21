using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Telephony
{
    public interface ISmartphone 
    {
        string Browse(string url);
        string Calling(string number);
    }
}
