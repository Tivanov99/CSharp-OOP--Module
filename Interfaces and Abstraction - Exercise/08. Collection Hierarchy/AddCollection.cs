using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    public class AddCollection :  IAddCollection
    {
        private string[] array;
        private int count;
        public AddCollection(int size)
        {
            array = new string[size];
            count = -1;
        }


        public int Add(string element)
        {
            string[] coppy = new string[array.Length];
            for (int i = 1; i < array.Length-1; i++)
            {
                coppy[i] = array[i];
            }
            array = coppy;
            count++;
            return count;
        }
    }
}
