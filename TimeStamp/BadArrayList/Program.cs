using System;
using System.Collections;

namespace BadArrayList
{
    class Program
    {
        private static ArrayList jobs = new ArrayList();
        private static int nextJobPos = 0;
        public static void AddJob(string jobName)
        {
            jobs.Add(jobName);
        }
        public static string GetNextJob()
        {
            if (nextJobPos > jobs.Count - 1)
                return "NO JOBS IN BUFFER";
            else
            {
                string jobName = (string)jobs[nextJobPos];
                nextJobPos++;
                return jobName;
            }
        }

        static void Main(string[] args)
        {
            AddJob("1");
            AddJob("2");
            Console.WriteLine(GetNextJob());
            AddJob("3");
            Console.WriteLine(GetNextJob());
            Console.WriteLine(GetNextJob());
            Console.WriteLine(GetNextJob());
            Console.WriteLine(GetNextJob());
            AddJob("4");
            AddJob("5");
            Console.WriteLine(GetNextJob());
        }
    }
}
