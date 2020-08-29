using System;

namespace Enums
{
    enum CaseColor
    {
        Uncolored = 0,
        Red = 8001,
        Blue = 9001
    }

    class Program
    {
        static void Main(string[] args)
        {
            // зрозуміліше
            Console.WriteLine("COLOR: {0}, {1}",
                CaseColor.Blue,
                (int)CaseColor.Blue);

            // складніше для розуміння
            Console.WriteLine("COLOR: {0}, {1}",
                "Blue",
                9001);
        }
    }
}
