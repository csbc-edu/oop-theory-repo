using System;

namespace NullArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{10 / null ?? 0}");
            Console.WriteLine($"{10 * null ?? 0}");
            Console.WriteLine($"{10 + null ?? 0}");
            Console.WriteLine($"{10 - null ?? 0}");
            Console.WriteLine($"{10 % null ?? 0}");
            Console.WriteLine($"{null / 10 ?? 0}");
            Console.WriteLine($"{null * 10 ?? 0}");
            Console.WriteLine($"{null + 10 ?? 0}");
            Console.WriteLine($"{null - 10 ?? 0}");
            Console.WriteLine($"{null % 10 ?? 0}");
            Console.WriteLine($"{null / null ?? 0}");
            Console.WriteLine($"{null * null ?? 0}");
            //Console.WriteLine($"{null + null ?? 0}");
            Console.WriteLine($"{null - null ?? 0}");
            Console.WriteLine($"{null % null ?? 0}");
            //Console.WriteLine($"{null == null ?? 0}");
        }
    }
}