using System;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Створюємо одновимірний масив з 5 цілих чисел.
            int[] array1 = new int[5];

            // Оголошуємо та ініціалізуємо елементи масиву.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Альтернативний синтаксис.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Оголошуємо двовимірний масив.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Оголошуємо та ініціалізуємо елементи масиву.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Оголошуємо зубчастий (jagged) масив.
            int[][] jaggedArray = new int[6][];

            // Ініціалізуємо перший масив у структурі зубчастого масиву.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

            // ітерування по одновимірному масиву
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            foreach (int i in numbers)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            // ітерування по багатовимірному масиву
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            // або коротка форма:
            // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            foreach (int i in numbers2D)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            // ітерування по зубчастому масиву.
            int[][] arr = new int[2][];
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements.
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ранг масиву: {0}", arr.Rank);

            // LINQ
            int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = from n in nums 
                          select n;

            Console.WriteLine("Всі числа: ");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Всі парні числа: ");
            lowNums = (from n in numbers
                       where (n % 2 == 0)
                       select n);

            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }

            // клас Array
            Array stringArray = Array.CreateInstance(typeof(string), 3);
            stringArray.SetValue("Іван Петрович", 0);
            stringArray.SetValue("Степан Іванович", 1);
            stringArray.SetValue("Олексій Степанович", 2);

            Console.WriteLine("Багатовимірний Array");
            Array intArray3D = Array.CreateInstance(typeof(Int32), 2, 3, 4);
            for (int i = intArray3D.GetLowerBound(0); i <= intArray3D.GetUpperBound(0); i++)
                for (int j = intArray3D.GetLowerBound(1); j <= intArray3D.GetUpperBound(1); j++)
                    for (int k = intArray3D.GetLowerBound(2); k <= intArray3D.GetUpperBound(2); k++)
                    {
                        intArray3D.SetValue((i * 100) + (j * 10) + k, i, j, k);
                    }
            foreach (int ival in intArray3D)
            {
                Console.WriteLine(ival);
            }

            // пошук
            // методи вимагають аргументи більш конкретного типу, ніж Array
            string[] array = (string[])stringArray;

            string res = Array.Find(array, ele => ele.StartsWith("С"));
            Console.WriteLine("Результат пошуку методом Find():");
            Console.WriteLine(res);

            string[] res2 = Array.FindAll(array, element => element.Contains("Іван"));
            Console.WriteLine("Результат пошуку методом FindAll():");
            foreach (var result in res2)
            {
                Console.WriteLine(result);
            }

            string res3 = Array.FindLast(array, element => element.Contains("Степан"));
            Console.WriteLine("Результат пошуку методом FindLast():");
            Console.WriteLine(res3);

            // сортування
            int[] myNums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Array.Sort(myNums, 0, myNums.Length);
            foreach(int num in myNums)
                Console.Write("{0}\t", num);
            Console.WriteLine();
            Console.WriteLine("Елемент із значенням -10 знаходиться по індексу {0}",
                                Array.BinarySearch(myNums, -10));
            Console.WriteLine("Елемент із значенням 1 знаходиться по індексу {0}",
                                Array.BinarySearch(myNums, 1));

            // копіювання, клонування
            Console.WriteLine("\nХеш-код оригіналу: {0}", myNums.GetHashCode());

            int[] copiedNums = new int[myNums.Length]; 
            Array.Copy(myNums, myNums.GetLowerBound(0), copiedNums, copiedNums.GetLowerBound(0), 10);
            Console.WriteLine("Скопійований масив: ");
            for (int i = 0; i <= copiedNums.GetUpperBound(0); i++) 
                Console.Write($"{copiedNums.GetValue(i)}\t");
            Console.WriteLine("\nХеш-код копії: {0}", copiedNums.GetHashCode());

            int[] clonedNums = (int[])myNums.Clone();           
            Console.WriteLine("Клонований масив: ");
            for (int i = 0; i <= clonedNums.GetUpperBound(0); i++)
                Console.Write($"{clonedNums.GetValue(i)}\t");
            Console.WriteLine();
            Console.WriteLine("\nХеш-код клону: {0}", clonedNums.GetHashCode());

            Console.WriteLine("Чи однакові посилання на оригінал та копію?\t {0}", object.ReferenceEquals(myNums, copiedNums));
            Console.WriteLine("Чи однакові посилання на оригінал та клон?\t {0}", object.ReferenceEquals(myNums, clonedNums));
            Console.WriteLine("Чи однакові посилання на копію та клон?\t {0}", object.ReferenceEquals(copiedNums, clonedNums));

            // реверс та очищення
            Array.Reverse(myNums);
            Array.Clear(clonedNums, 4, 6);
            myNums[0] = 100;

            Console.Write("Початковий масив після реверсу:\t\t ");
            for (int i = 0; i <= myNums.GetUpperBound(0); i++)
                Console.Write($"{myNums.GetValue(i)}\t");
            Console.WriteLine();

            Console.Write("Скопійований масив після реверсу:\t ");
            for (int i = 0; i <= copiedNums.GetUpperBound(0); i++)
                Console.Write($"{copiedNums.GetValue(i)}\t");
            Console.WriteLine();

            Console.Write("Клонований масив після реверсу:\t\t ");
            for (int i = 0; i <= clonedNums.GetUpperBound(0); i++)
                Console.Write($"{clonedNums.GetValue(i)}\t");
            Console.WriteLine();

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
