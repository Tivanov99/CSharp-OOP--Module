using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int Actions = int.Parse(Console.ReadLine());
            AddCollection addCollection = new AddCollection(input.Length);
            MyList myList = new MyList(input.Length);
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection(input.Length);
            for (int i = 0; i < 5; i++)
            {
                if(i==0)
                {
                    for (int S = 0; S < input.Length; S++)
                    {
                        Console.Write(addCollection.Add(input[S])+ " ");
                    }
                    Console.WriteLine();
                }
                else if(i==1)
                {
                    for (int S = 0; S < input.Length; S++)
                    {
                        Console.Write(addRemoveCollection.Add(input[S]) + " ");
                    }
                    Console.WriteLine();
                }
                else if(i==2)
                {
                    for (int S = 0; S < input.Length; S++)
                    {
                        Console.Write(myList.Add(input[S]) + " ");
                    }
                    Console.WriteLine();
                }
                else if(i==3)
                {
                    string[] outt = new string[Actions];
                    for (int S = 0; S < Actions; S++)
                    {
                        outt[S] = addRemoveCollection.Remove();
                    }
                    Console.WriteLine(string.Join(" ", outt));
                }
                else if (i == 4)
                {
                    string[] outt = new string[Actions];
                    for (int S = 0; S < Actions; S++)
                    {
                        outt[S]=myList.Remove();
                    }
                    Console.WriteLine(string.Join(" ",outt));
                }
            }
        }
    }
}
