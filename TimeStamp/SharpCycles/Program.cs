using System;
using System.Text;

namespace SharpLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /**
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Квадрат числа {i} дорівнює {i * i}");
            }

            Console.WriteLine();

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Квадрат числа {i} дорівнює {i * i}");
            }

            Console.WriteLine();

            int j = 0;
            for (; ; )
            {
                if(j == 10)
                {
                    break;
                }
                Console.WriteLine($"Квадрат числа {++j} дорівнює {j * j}");
            }

            Console.WriteLine();

            j = 0;
            for (; j< 10; )
            {
                Console.WriteLine($"Квадрат числа {++j} дорівнює {j * j}");
            }

            Console.WriteLine();

            int number;

            for (; int.TryParse(Console.ReadLine(), out number); )
            {
                Console.WriteLine($"Квадрат числа {number} дорівнює {number * number}");
            } 
            */

            /**
            var str = "Hello, world!";
            var ints = new int[] { 9, -6, 7, 8, 0, 1 };

            int index = 0;
            foreach (var c in str)
            {
                Console.WriteLine($"Символ '{c}' на позиції {index}");
                index++;
            }

            foreach (int i in ints)
            {
                if (i < 0)
                    continue;
                Console.WriteLine("число {0}", i);  
            }
            */
            int k = 0;

            Console.WriteLine("while: ");
            while (k < 5)
            {
                Console.WriteLine($"k = {k}");
                k++;
            }

            Console.WriteLine("do-while: ");
            do
            {
                Console.WriteLine($"k = {k}");
                k++;
            } while (k > 10);

            Console.WriteLine("Циклічний ввід:");
            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out k))
                {
                    break; 
                }
                Console.WriteLine($"Ви ввели число {k}");

            }

        }
    }
}
