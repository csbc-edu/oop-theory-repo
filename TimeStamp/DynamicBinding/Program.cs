using System;

namespace DynamicBinding
{
    class Person
    {
        public void Go() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic p = new Person();
            //p.Go();
            p.Go(100);
            p.Eat();
            var name = p.name;
            var Employee.Salary(name);
        }
    }
}
