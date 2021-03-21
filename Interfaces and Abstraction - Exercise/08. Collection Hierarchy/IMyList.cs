using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    public interface IMyList : IAddRemoveCollection
    {
        public int GetCount { get; }
    }
}
