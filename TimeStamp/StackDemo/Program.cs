using System;
using System.Collections;

namespace StackDemo
{
    class Program
    {
        static void StackInfo(Stack st)
        {
            Console.WriteLine("Кількість елементів у стеку = " + st.Count);
            Console.WriteLine("Вершина стеку = " + st.Peek());
            

            foreach (Object obj in st)
            {
                Console.WriteLine("| " + obj + " |");
                Console.WriteLine("------");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push(10);
            st.Push(20);
            st.Push(30);
            StackInfo(st);
            
            st.Pop();
            StackInfo(st);
            Console.WriteLine("Чи є у стеку трійка? " + st.Contains(3));
        }
    }
}
