using System;

namespace SharpProperties
{
    public class Customer
    {
        private object syncHandle = new object(); 
        private string name; 
        public string Name { 
            get { lock (syncHandle) return name; } 
            set { 
                if (string.IsNullOrEmpty(value)) 
                    throw new ArgumentException(
                        "Name cannot be blank", nameof(Name)); 
                lock (syncHandle) name = value; 
            } 
        }

        public int this[int index] { 
            get => theValues[index]; 
            set => theValues[index] = value; 
        }
        private int[] theValues = new int[100];
        // доступ до індексатора: int val = someObject[i]; 

        /**
        public Address this[string name] { 
            get => addressValues[name]; 
            set => addressValues[name] = value; 
        }
        private Dictionary<string, Address> addressValues;
        */

        //public int this[int x, int y] => ComputeValue(x, y);
        //public int this[int x, string name] => ComputeValue(x, name);

    }

    /**
    public class Customer
    {
        public virtual string Name { get; protected set; }    
        // remaining implementation omitted 
    }
    */




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
