using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CustomGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            var trainings = new Trainings();
            trainings.Insert(0, new Training { Name = "C#", Cost = 10 });
            trainings.Add(new Training() { Name = "Java", Cost = 10 });

            trainings.ForEach(Console.WriteLine);
            Console.ReadKey();
            */
           
            var trainings = new TrainingsCollection<Training>();
            trainings.Add(new Training { Name = "C#", Cost = 10 });
            trainings.Add(new Training() { Name = "Java", Cost = 10 });

            // This loop with trigger to IEnumerator<T> GetEnumerator() from our custom TraningsEnumerator
            foreach (var item in trainings)
            {
                Console.Write($"Traning Name {item.Name} and cost {item.Cost}\n");
            }

            Console.ReadKey();   
        }
    }
}
