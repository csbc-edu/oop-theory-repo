using System;
using System.Text;

namespace ValueVsRefference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // значимі типи
            int i = 1;
            double j;

            // посилальні типи 
            object obj = null;
            string str = String.Empty;

            // нулабельні типи
            int? k = null;
            int? f = 23;

            Console.WriteLine($"Значимі типи: i = {i}");
            //Console.WriteLine("j = {j}");     // помилка
            Console.WriteLine($"Посилальні типи: obj = {obj}, str = {str}");
            Console.WriteLine($"Нулабельні типи: k = {k}, f = {f}");
        }
    }
}
