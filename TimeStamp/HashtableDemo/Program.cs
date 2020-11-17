using System;
using System.Collections;

namespace HashtableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
                            {"UK", "London, Manchester, Birmingham"},
                            {"USA", "Chicago, New York, Washington"},
                            {"India", "Mumbai, New Delhi, Pune"}
                        };

            Console.WriteLine();
            foreach (DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            string citiesOfUK = (string)cities["UK"]; //cast to string
            string citiesOfUSA = (string)cities["USA"]; //cast to string

            Console.WriteLine();
            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfUSA);

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key

            if (!cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            cities.Remove("UK"); // removes UK 
            //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            cities.Clear(); //removes all elements
        }
    }
}
