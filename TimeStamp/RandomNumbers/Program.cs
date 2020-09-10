using System;
using System.Threading;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed1 = (int)DateTime.Now.Ticks & 0x0000FFFF;
            Console.WriteLine("Seed = {0}", seed1);
            Random rand1 = new Random(seed1);
            ShowRandomNumbers(rand1);
            
            Random rand2 = new Random(seed1);
            ShowRandomNumbers(rand2);
            
            Thread.Sleep(20);
            int seed3 = (int)DateTime.Now.Ticks & 0x0000FFFF;
            Console.WriteLine("Seed = {0}", seed3);
            Random rand3 = new Random(seed3);          
            ShowRandomNumbers(rand3);
        }

        private static void ShowRandomNumbers(Random rand)
        {
            Console.WriteLine();
            byte[] values = new byte[4];
            rand.NextBytes(values);
            foreach (var value in values)
                Console.Write("{0, 5}", value);

            Console.WriteLine();
        }
    }
}
