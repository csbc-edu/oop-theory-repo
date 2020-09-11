using System;
using System.Diagnostics;
using System.Text;

namespace Characters
{
    class Program
    {
        public static TimeSpan Time(Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public static int SayCode(char sym) { return sym; }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Статичні методи класу char:");
            char ch = 'a', ch1 = '1', lim = ';', chc = '\xA';
            double d1, d2;
            d1 = char.GetNumericValue(ch);
            d2 = char.GetNumericValue(ch1);
            Console.WriteLine("Метод GetNumericValue:");
            Console.WriteLine("sym 'a' - value {0}", d1);
            Console.WriteLine("sym '1' - value {0}", d2);
            System.Globalization.UnicodeCategory cat1, cat2;
            cat1 = char.GetUnicodeCategory(ch1);
            cat2 = char.GetUnicodeCategory(lim);
            Console.WriteLine("Метод GetUnicodeCategory:");
            Console.WriteLine("sym '1' - category {0}", cat1);
            Console.WriteLine("sym ';' - category {0}", cat2);
            Console.WriteLine("Метод IsControl:");
            Console.WriteLine("sym '\xA' - IsControl - {0}", char.IsControl(chc));
            Console.WriteLine("sym ';' - IsControl - {0}", char.IsControl(lim));
            Console.WriteLine("Метод IsSeparator:");
            Console.WriteLine("sym ' ' - IsSeparator - {0}", char.IsSeparator(' '));
            Console.WriteLine("sym ';' - IsSeparator - {0}", char.IsSeparator(lim));
            Console.WriteLine("Метод IsSurrogate:");
            Console.WriteLine("sym '\u10FF' - IsSurrogate - {0}", char.IsSurrogate('\u10FF'));
            Console.WriteLine("sym '\\' - IsSurrogate - {0}", char.IsSurrogate('\\'));
            string str = "\U00010F00";
            
            // Символи Unicode з інтервалу [0x10000,0x10FFF]
            // представляються двома 16-бітними суррогатными символами
            Console.WriteLine("str = {0}, str[0] = {1}", str, str[0]);
            Console.WriteLine("str[0] IsSurrogate - {0}", char.IsSurrogate(str, 0));
            Console.WriteLine("Метод IsWhiteSpace:");
            str = "пробіли, пробіли!" + "\xD" + "\xA" + "Повсюди пробіли!";
            Console.WriteLine("sym '\xD ' - IsWhiteSpace - {0}", char.IsWhiteSpace('\xD'));
            Console.WriteLine("str: {0}", str);
            Console.WriteLine("і ще пробіли - символ 8 {0}," + "символ 17 {1}",
                                char.IsWhiteSpace(str, 8), char.IsWhiteSpace(str, 17));
            Console.WriteLine("Метод Parse:");
            str = "A";
            ch = char.Parse(str);
            Console.WriteLine("str:{0}  char: {1}", str, ch);
            Console.WriteLine("Мінімальне й максимальне значення: {0}, {1}",
               char.MinValue.ToString(), char.MaxValue.ToString());
            Console.WriteLine("Їх коди: {0}, {1}", SayCode(char.MinValue), SayCode(char.MaxValue));

            int n = 1000000;
            TimeSpan time = Time(() =>
            {
                // Use a new char array.
                char[] buffer = new char[n];
                for (int i = 0; i < n; i++)
                {
                    buffer[i] = 'a';
                }
                string result = new string(buffer);
            });
            Console.WriteLine("Робота масиву символів займає {0}", time.TotalMilliseconds);

            TimeSpan time2 = Time(() =>
            {
                // Declare new StringBuilder and append to it 100 times.
                StringBuilder builder = new StringBuilder(n);
                for (int i = 0; i < n; i++)
                {
                    builder.Append('a');
                }
                string result = builder.ToString();
            });
            Console.WriteLine("Робота символьного рядка займає {0}", time2.TotalMilliseconds);

            TimeSpan time3 = Time(() =>
            {
                // Declare new StringBuilder and append to it 100 times.
                string result = "";
                for (int i = 0; i < n; i++)
                {
                    result += 'a';
                }
            });

            Console.WriteLine("Робота рядка займає {0}", time3.TotalMilliseconds);
        }
    }
}
