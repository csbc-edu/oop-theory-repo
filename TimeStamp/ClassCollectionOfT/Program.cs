using System;
using System.Collections.ObjectModel;

namespace ClassCollectionOfT
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection<string> myColl = new Collection<string>();

            myColl.Add("A");
            myColl.Add("B");
            myColl.Add("C");
            myColl.Add("D");
            myColl.Add("E");

            Console.WriteLine(myColl.Contains("A"));

            string[] myArr = new string[myColl.Count];
            myColl.CopyTo(myArr, 0);

            // виведення елементів з myArr 
            foreach (string str in myArr) { Console.WriteLine(str); }
        }
    }
}
