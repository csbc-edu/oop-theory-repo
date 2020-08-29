using System;
using System.Text;

namespace SharpJumpStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("break та вкладені цикли:");
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    int product = i * j;

                    if (product >= 20)
                    {
                        Console.WriteLine("\nОбчислення закінчені.");
                        break;
                    }

                    Console.Write("{0}\t", product);
                }
                Console.Write("\n");
            }

            Console.WriteLine("goto та вкладені цикли:");
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    int product = i * j;

                    if (product >= 20)
                    {
                        goto LoopEnd;
                    }

                    Console.Write("{0}\t", product);
                }
                Console.Write("\n");
            }

        LoopEnd:
            Console.WriteLine("\nОбчислення закінчені.");
        }
    }
}
