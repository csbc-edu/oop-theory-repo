using System;
using System.Collections.Generic;

namespace GenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };

            Console.WriteLine(numberNames[1]); //output: One
            Console.WriteLine(numberNames[2]); //output: Two
            Console.WriteLine(numberNames[3]); //output: Three
            //Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

            numberNames[2] = "TWO"; //updates value
            numberNames[4] = "Four"; //adds a new key-value if a key does not exists

            Console.WriteLine();
            for (int i = 0; i < numberNames.Count; i++)
                Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i], numberNames.Values[i]);

            numberNames.Remove(1);//removes key 1 pair
            numberNames.Remove(10);//removes key 1 pair, no error if not exists

            numberNames.RemoveAt(0);//removes key-value pair from index 0 
            //numberNames.RemoveAt(10);//run-time exception: ArgumentOutOfRangeException

            Console.WriteLine();
            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }
    }
}
