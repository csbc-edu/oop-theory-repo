using System;

namespace CoersionPolymorphism
{
    class Superclass { }

    class Subclass : Superclass { }

    class Program
    {
        static void Main(string[] args)
        {
            Subclass sub = new Subclass();
            Superclass super = sub;             // Implicit cast
            Subclass sub2 = (Subclass)super;    // Explicit cast

            Superclass super2 = new Superclass();
            // Subclass sub12 = (Subclass)super2;             // Exception

            Subclass sub3 = new Subclass();
            Superclass super3 = sub3;
            Subclass sub23 = super3 as Subclass;
            if (sub == null)
            {
                Console.WriteLine("Несумісні типи!");    
            }
        }
    }
}
