﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count == 0)
            {
                return true;
            }
            return false;
        }
        public Stack<string> AddRange(List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                this.Push(input[i]);
            }
            return this;
        }
    }
}
