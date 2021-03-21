using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private string[] array;
        private int count;
        public AddRemoveCollection(int size)
        {
            array = new string[size];
            count = 0;
        }

        public int Add(string element)
        {
            string[] coppy = new string[array.Length];
            coppy[0] = element;
            for (int i = 0; i < array.Length - 1; i++)
            {
                coppy[i + 1] = array[i];
            }
            array = coppy;
            count++;
            return 0;
        }

        public string Remove()
        {
            string element = "";
            string[] coppy = new string[array.Length];
            element = array[count - 1];
            for (int i = 0; i < count - 1; i++)
            {
                coppy[i] = array[i];
            }
            array = coppy;
            count--;
            return element;
        }
    }
}
