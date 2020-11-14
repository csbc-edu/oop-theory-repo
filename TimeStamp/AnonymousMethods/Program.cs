using System;

namespace AnonymousMethods
{
    class Program
    {
        public delegate void petanim(string pet);

        // Main method 
        static public void Main()
        {
            // An anonymous method with one parameter 
            petanim p = delegate (string mypet)
            {
                Console.WriteLine("My favorite pet is: {0}", mypet);
            };
            p("Dog");
        }
    }
}
