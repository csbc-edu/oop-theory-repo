using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            int j = i ?? 0;
            int k = -1000;

            Console.WriteLine(j);
            // null менший за інші значення
            Console.WriteLine(k < i);
            Console.WriteLine(Nullable.Compare<int>(k, i) < 0);
        }
    }
}
