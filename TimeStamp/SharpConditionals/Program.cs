using System;
using System.Text;

namespace SharpConditionals
{
    public enum Color { Red, Green, Blue }

    class Program
    {
        public enum Directions
        {
            Up,
            Down,
            Right,
            Left
        }

        public enum Orientation
        {
            North,
            South,
            East,
            West
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /**
            // if-else
            Console.WriteLine("Логін: ");
            string login = Console.ReadLine();
            Console.WriteLine("Пароль: ");
            string password = Console.ReadLine();

            if (login == "admin" && password == "password")
            {
                Console.WriteLine("Вітаю, Ви авторизовані!");
                Console.WriteLine("Скільки Вам років?");
                int age;
                if(int.TryParse(Console.ReadLine(), out age)) {
                    if (age >= 18)
                    {
                        Console.WriteLine("Повнолітнім доступ дозволено!");
                    }
                    else if(age > 0) 
                    {
                        Console.WriteLine("Неповнолітнім доступ заборонено!");
                    }
                    else
                    {
                        Console.WriteLine("Спочатку народіться на цей світ!");
                    }
                } else
                {
                    Console.WriteLine("Некоректно введений вік!");
                }    
            }
            else
            {
                Console.WriteLine("Неправильний логін чи пароль!");
            }
            */

            // ?:
            /**
            int x = 20, y = 10, z;

            var result = x > y ? "x більше y" : "x менше або дорівнює y";
            Console.WriteLine(result);

            Console.WriteLine("Введіть третє число: ");
            // обчислення максимального значення з трьох чисел
            int.TryParse(Console.ReadLine(), out z);
            var max = x > y ? x > z ? x : z : y > z ? y : z;
            Console.WriteLine($"Максимум: {max} ");
            */
            // switch
            /**
            Color c = (Color)(new Random()).Next(0, 3);
            switch (c)
            {
                case Color.Red:
                    Console.WriteLine("Червоний колір");
                    break;
                case Color.Green:
                    Console.WriteLine("Зелений колір");
                    break;
                case Color.Blue:
                    Console.WriteLine("Синій колір");
                    break;
                default:
                    Console.WriteLine("Даний колір невідомий!");
                    break;
            }
            */

            // switch expression
            var direction = Directions.Right;
            Console.WriteLine($"Map view direction is {direction}");

            var orientation = direction switch
            {
                Directions.Up => Orientation.North,
                Directions.Right => Orientation.East,
                Directions.Down => Orientation.South,
                Directions.Left => Orientation.West,
            };
            Console.WriteLine($"Cardinal orientation is {orientation}");
        }
    }
}
