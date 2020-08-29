using System;
using System.Text;

namespace NullConditional
{   
    class Program
    {
        struct Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public static void DisplayPerson(Person? person)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine(person?.FirstName ?? "Ім'я за умовчанням");
                Console.WriteLine(person?.LastName ?? "Прізвище за умовчанням");
            }
        }

        static void Main(string[] args)
        {

            Person? person1 = null;
            Person? person2 = new Person { 
                FirstName = "Станіслав", LastName = null };
            Person.DisplayPerson(person1);
            Person.DisplayPerson(person2);
            Person?[] persons = new Person?[2] { person1, person2 };
            Console.WriteLine(persons?[1].Value.FirstName ?? "Порожнє ім'я");
            Console.WriteLine(persons?[1].Value.LastName ?? "Порожнє прізвище");
            
        }
    }
}
