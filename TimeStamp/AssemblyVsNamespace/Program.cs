using System;       // тип Console для вводу-виводу в консоль
                    // тип Type для отримання даних про тип
using System.Reflection;    // рефлексія для отримання збірки
using System.Text;  // для узгодження кодування тексту 
                    // в редакторі (UTF-8) та консолі (chcp 1251)

namespace AssemblyVsNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // узгоджуємо кодування для виводу букви і
            Console.OutputEncoding = Encoding.UTF8;
            // вивід тексту з переходом на новий рядок
            Console.WriteLine("Привіт, світ!");
            // змінна, яка описує тип Console
            Type t = typeof(Console);
            // отримуємо збірку, в якій знаходиться опис типу
            Assembly assem = Assembly.GetAssembly(t);
            // виводимо дані про збірку та простір імен
            Console.WriteLine("Збірка: {0}", assem.FullName);
            Console.WriteLine("Простір імен: {0}", t.Namespace);
            Console.ReadKey(); // щоб вікно консолі не закрилось
        }
    }
}
