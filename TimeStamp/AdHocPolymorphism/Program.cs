using System;

namespace AdHocPolymorphism
{
    class Program
    {
        // Method 
        public void Identity(String name, int id)
        {

            Console.WriteLine("Name : " + name + ", " + "Id : " + id);
        }

        // додавання 2 цілих чисел. 
        public int Add(int a, int b)
        {
            return a + b;
        }

        // зміна кількості параметрів:
        // додавання троьх цілих чисел. 
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // зміна типів параметрів:
        // додавання трьох дійсних чисел подвійної точності. 
        public double Add(double a, double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }
            
        // зміна порядку параметрів 
        public void Identity(int id, String name)
        {
            Console.WriteLine("Name : " + name + ", " + "Id : " + id);
        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            int sum1 = obj.Add(1, 2);

            Console.WriteLine("sum of the two "
                          + "integer value : " + sum1);
            
            int sum2 = obj.Add(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum2);

            double sum3 = obj.Add(1.0, 2.0, 3.0);
            Console.WriteLine("sum of the three "
                              + "double value : " + sum3);

            obj.Identity("Akku", 1);
            obj.Identity("Abby", 2);

            // using overloaded - operator  
            // with the class object 
            Calculator calc = new Calculator(15, -25);

            calc = -calc;

            // To display the result 
            calc.Print();

            Calculator2 num1 = new Calculator2(200);
            Calculator2 num2 = new Calculator2(40);
            Calculator2 num3 = new Calculator2();


            num3 = num1 + num2;

            num1.display(); // Displays 200 
            num2.display(); // Displays 40 
            num3.display(); // Displays 240 
        }
    }
}
