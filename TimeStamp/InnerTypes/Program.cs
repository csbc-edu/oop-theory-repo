using System;

namespace InnerTypes
{
    public class Outer_class
    {

        // Static data member of the outer class 
        public static string str = "Geeksforgeeks";

        // Inner class 
        public class Inner_class
        {
            // Non-static data  
            // member of outer class 
            public int number = 1000000;

            // Static method of Inner class 
            public static void method1()
            {
                // Displaying the value of a 
                // static member of the outer class 
                Console.WriteLine(Outer_class.str);

                // Creating the object of the outer class 
                Outer_class obj = new Outer_class();

                // Displaying the value of a  
                // static member of the outer class 
                // with the help of obj 
                // Console.WriteLine(obj.number);
            }
        }

        

}

    class Program
    {
        static void Main(string[] args)
        {
            // Accessing static method1  
            // of the inner class 
            Outer_class.Inner_class.method1();

            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
        }
    }
}
