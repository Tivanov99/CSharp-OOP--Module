using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;
        public string RandomString(List<string> input)
        {
            random = new Random();
            int index = random.Next(0, input.Count - 1);
            string currentElement = input[index];
            input.RemoveAt(index);
            return input[index];
        }
    }
}
