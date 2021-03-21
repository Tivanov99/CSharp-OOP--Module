using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    public class MyList : IMyList
    {
        private string[] array;
        private int count;
        int index;
        public MyList(int size)
        {
            array = new string[size];
        }
        public int GetCount => this.count;

        public string Remove()
        {
            string[] coppy = new string[array.Length];
            string element = array[index];
            for (int i = 1; i < array.Length - 1; i++)
            {
                coppy[i] = array[i];
            }
            count--;
            index++;
            return element;
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
    }
}
