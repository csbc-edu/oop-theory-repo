using System;
using System.Collections.Generic;

namespace ListOfTDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            Console.WriteLine(primeNumbers[0]); 
            Console.WriteLine(primeNumbers[1]); 
            Console.WriteLine(primeNumbers[2]); 
            Console.WriteLine(primeNumbers[3]);

            primeNumbers.Insert(1, 11);// inserts 11 at 1st index: after 10.
            primeNumbers.Remove(7);
            

            // using foreach LINQ method
            primeNumbers.ForEach(num => Console.Write(num + ", "));

            primeNumbers.RemoveAt(1);

            // using for loop
            for (int i = 0; i < primeNumbers.Count; i++)
                Console.WriteLine(primeNumbers[i]);

            Console.WriteLine("Is 11 in primeNumbers? {0}", primeNumbers.Contains(11));
        }
    }
}
