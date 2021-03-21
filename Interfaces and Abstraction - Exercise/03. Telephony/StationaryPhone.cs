using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        public string Calling(string number)
        {
            return $"Dialing... {number}";
        }
    }
}
