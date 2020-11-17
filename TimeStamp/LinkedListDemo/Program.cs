using System;
using System.Collections.Generic;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> L = new LinkedList<int>();
            L.AddFirst(5);
            L.AddFirst(2);
            L.AddFirst(8);
            L.AddLast(4);
            L.AddLast(9);
            L.AddLast(1);
            L.AddBefore(L.Find(9), new LinkedListNode<int>(7));

            Console.Write("Linked List elements are: ");
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }

            L.RemoveFirst();
            L.RemoveLast();
            L.Find(2).Value = 12;
          
            Console.Write("\nLinked List after deletion: ");
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nThe value 3 is present in Linked List: " + L.Contains(3));
            Console.WriteLine("The value 5 is present in Linked List: " + L.Contains(5));
        }
    }
}
