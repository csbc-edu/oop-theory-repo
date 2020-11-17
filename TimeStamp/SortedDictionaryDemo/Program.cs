using System;
using System.Collections.Generic;

namespace SortedDictionaryDemo
{
    class UserInfo
    {
        // Метод, реализующий словарь
        public static SortedDictionary<string, string> MyDic(int i)
        {
            SortedDictionary<string, string> dic = new SortedDictionary<string, string>();
            string s, s1;
            for (int j = 0; j < i; j++)
            {
                Console.Write("\nВведіть ключ: ");
                s1 = Console.ReadLine();
                Console.WriteLine("Введіть ім'я працівника");
                Console.Write("Name{0} --> ", j);
                s = Console.ReadLine();
                dic.Add(s1, s);
            }
            return dic;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Скільки працівників додати? ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                SortedDictionary<string, string> dic = UserInfo.MyDic(i);

                // Получить коллекцию ключей
                ICollection<string> keys = dic.Keys;

                Console.WriteLine("\nВідсортована база даних містить: ");
                foreach (string j in keys)
                    Console.WriteLine("ID -> {0}  Name -> {1}", j, dic[j]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректне введення!");
            }

            Console.ReadLine();
        }
    }
}
