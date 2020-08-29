using System;
using System.Globalization;
using System.Text;

namespace TimeStamp
{
    class Program
    {
        public static void PrintTimeStamp(string name)
        {
            // підтримка букви "і" в консолі 
            Console.OutputEncoding = Encoding.UTF8;

            // отримання локального часу
            DateTime localDate = DateTime.Now;

            // формат виводу дати для України
            var culture = new CultureInfo("ru-RU");
            Console.WriteLine("   Дата та час компіляції: {0}",
                                  localDate.ToString(culture));
            Console.WriteLine("   Автор: {0}", name);
        }
        static void Main(string[] args)
        {
            PrintTimeStamp("Ім'я Прізвище, студент групи 1П18");
        }
    }
}
