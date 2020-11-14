using System;

namespace DelegateEvolution
{
    class Program
    {
        delegate void TestDelegate(string s);
        static void M(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            // Початковий синтаксис делегата для
            // ініціалізації іменованим методом.
            TestDelegate testDelA = new TestDelegate(M);

            // C# 2.0: делегат може ініціалізуватись за допомогою
            // вбудованого (inline) коду, що називають "анонімним методом". 
            // Цей метод приймає рядок у якості вхідного параметру.
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };

            // C# 3.0. Делегат може ініціалізуватись за допомогою
            // лямбда-виразу. Лямбда також приймає рядок у якості
            // вхідного параметру (x). Тип x виводиться (is inferred) компілятором.
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };

            // Виклик делегатів.
            testDelA("Hello. My name is M and I write lines.");
            testDelB("That's nothing. I'm anonymous and ");
            testDelC("I'm a famous author.");

            // Тримаємо вікно консолі в режимі debug.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
