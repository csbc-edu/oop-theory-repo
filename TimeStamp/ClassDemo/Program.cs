using System;
using System.Text;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // розміщення в пам'яті та конфігурація об'єкту типу Car
            Car myCar = new Car();
            myCar.petName = "Лола";
            myCar.currSpeed = 50;

            // збільшуємо швидкість автомобіля та виводимо новий стан
            for (int i = 0; i<= 10; i++)
            {
                myCar.SpeedUp(2);
                myCar.PrintState();
            }

            Car renaultZoe = new Car();
            renaultZoe.PrintState();

            Car plymouthFury = new Car("Крістіна");
            plymouthFury.PrintState();

            Car nissan = new Car("Сильвія", 110);
            nissan.PrintState();

            Console.ReadKey();
        }
    }
}
