using System;
using System.Collections.Generic;
using System.Text;

namespace AdHocPolymorphism
{
    class Calculator2
    {
        public int number = 0;

        // безаргументний конструктор 
        public Calculator2() { }


        // параметризований конструктор 
        public Calculator2(int n)
        {
            number = n;
        }

        // перевантаження бінарного оператора "+" 
        public static Calculator2 operator +(Calculator2 Calc1,
                                             Calculator2 Calc2)
        {
            Calculator2 Calc3 = new Calculator2(0);
            Calc3.number = Calc2.number + Calc1.number;
            return Calc3;
        }

        // метод для виводу результату 
        public void display()
        {
            Console.WriteLine("{0}", number);
        }
    }
}
