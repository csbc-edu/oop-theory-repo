using System;

namespace DynamicType
{
    class Student { }

    class Program
    {
        static void Main(string[] args)
        {
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", 
                MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", 
                MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", 
                MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", 
                MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = new Student();

            // випадки з помилкою виконання, проте не компіляції
            /*
            MyDynamicVar.DisplayStudentInfo(1, "Станіслав");
            MyDynamicVar.DisplayStudentInfo("1");
            MyDynamicVar.FakeMethod();
            */
            Nullable<Nullable<bool>> value;
        }
    }   
}
