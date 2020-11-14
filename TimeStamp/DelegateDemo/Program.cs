using System;

namespace DelegateDemo
{
    class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }

    // Declare a delegate
    delegate void Del();

    class SampleClass
    {
        public void InstanceMethod()
        {
            Console.WriteLine("A message from the instance method.");
        }

        static public void StaticMethod()
        {
            Console.WriteLine("A message from the static method.");
        }
    }


    class Program
    {
        delegate double MathCalculation(float value1, float value2);
        public delegate void MyDelegate(string msg); // оголошення делегата

        public static class Calculator
        {
            public static double AddNumbers(float value1, float value2)
            { return value2 + value2; }

            public static double DivideNumbers(float value1, float value2)
            { return value1 / value2; }
        }

        static void InvokeDelegate(MyDelegate del) // параметр типу MyDelegate
        {
            del(string.Format("Hello, {0}", del.Method.Name.ToString()));
        }

        static void Main(string[] args)
        {
            // присвоюємо змінним типу "делегат" метод з доречною сигнатурою
            MathCalculation add = Calculator.AddNumbers;
            MathCalculation divide = Calculator.DivideNumbers;

            // виклик делегата за допомогою Invoke
            var result = add.Invoke(2, 3);
            Console.WriteLine(result);

            // виклик делегата без Invoke
            var result2 = divide(100, 3);
            Console.WriteLine(result2);

            MyDelegate del = ClassA.MethodA;
            InvokeDelegate(del);

            del = ClassB.MethodB;
            InvokeDelegate(del);

            //del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            //InvokeDelegate(del);

            SampleClass sc = new SampleClass();
            Del d = sc.InstanceMethod; // Map the delegate to the instance method:
            d();
            d = SampleClass.StaticMethod; // Map to the static method:
            d();

        }
    }
}
