﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Contracts
{
    interface ICar
    {
        public string Model { get; }
        public string Color { get; }
        string Start();
        string Stop();
    }
}
