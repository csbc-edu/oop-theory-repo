using System;
using System.Collections.Generic;
using System.Text;

namespace AdHocPolymorphism
{
    class Calculator
    {
        public int number1, number2;
        public Calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }

        // функція для виконання операції 
        // зміни знаку цілих чисел 
        public static Calculator operator -(Calculator c1)
        {
            c1.number1 = -c1.number1;
            c1.number2 = -c1.number2;
            return c1;
        }

        // метод для виводу чисел 
        public void Print()
        {
            Console.WriteLine("Number1 = " + number1);
            Console.WriteLine("Number2 = " + number2);
        }
    }
}
