using System;
using System.Text;

namespace VerticalTab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            foreach (char c in "Hello, world!")
            {
                Console.Write("\v{0}", c);
            }

            Console.ReadKey();
        }
    }
}
