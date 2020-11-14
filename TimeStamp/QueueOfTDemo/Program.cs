using System;
using System.Collections.Generic;

namespace QueueOfTDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> student = new Queue<string>();

            //Adding item in queue
            student.Enqueue("Mark");
            student.Enqueue("Jack");
            student.Enqueue("Sarah");
            student.Enqueue("Smith");
            student.Enqueue("Robbie");
            print(student);

            //Removing Item
            Console.WriteLine("\nRemoving {0} from List. \nNew list is : ", student.Dequeue());
            print(student);

            //Copy Array Item to Queue
            string[] city = { "Newyork", "California", "Las Vegas" };
            Queue<string> citylist = new Queue<string>(city);
            Console.WriteLine("\nPrinting City List");
            print(citylist);

            //Count items in Queue
            Console.WriteLine("Count{0}", citylist.Count);
        }

        public static void print(Queue<string> q)
        {
            foreach (string s in q)
            {
                Console.Write(s.ToString() + " | ");
            }
        }
    }
}
