using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    class Car
    {
        // стан об'єкта Car
        public string petName;
        public int currSpeed;

        
        // спеціальний стандартний конструктор
        public Car()
        {
            petName = "Лада-седан Баклажан";
            currSpeed = 40;
        }

        // спеціальний конструктор з одним параметром
        // інший параметр отримує стандартне значення int - 0
        public Car(string name)
        {
            petName = name;
        }

        // спеціальний конструктор з двома параметрами
        // дозволяє встановити повний стан об'єкта типу Car
        public Car(string name, int speed)
        {
            petName = name;
            currSpeed = speed;
        }

        // функціональність Car
        public void PrintState()
        {
            Console.WriteLine("{0} рухається зі швидкістю {1} км/год.", petName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
