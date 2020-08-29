using System;
using System.Globalization;
using System.Text;

namespace ConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0}, {1}, {2}", 10, 20, 30);
            Console.WriteLine("{1}, {0}, {2}", 10, 20, 30);
            Console.WriteLine("{0}, {0}, {0}", 10, 20, 30);
            Console.WriteLine($"{30}, {20}, {10}");

            int i;
            Console.WriteLine("Введіть ціле число через TryParse: ");
            int.TryParse(Console.ReadLine(), out i);
            Console.WriteLine($"i = {i}", i);

            Console.WriteLine("Введіть ціле число через Parse: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine($"i = {i}", i);
            
            Console.WriteLine("Введіть ціле число через Convert: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"i = {i}", i);

            // ParseExact і TryParseExact додатково приймають формат розбору
            string dateString = "09-01-2020";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime dateTime;
            bool isSuccess = DateTime.TryParseExact(dateString, 
                new string[] { "MM/dd/yyyy", "MM-dd-yyyy", "MM.dd.yyyy" }, 
                provider, 
                DateTimeStyles.None, 
                out dateTime);
            Console.WriteLine(isSuccess);
        }
    }
}
