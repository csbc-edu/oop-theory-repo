using System;

namespace ReturnStatement
{
    class Program
    {
        static double CalculateArea(int r)
        {
            return r * r * Math.PI;
        }

        static void Main()
        {
            int radius = 5;
            double result = CalculateArea(radius);
            Console.WriteLine("Площа дорівнює {0:0.00}", result);

            Console.ReadKey();
        }
    }
}
