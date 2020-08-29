using System;

namespace SwitchExpression
{
    class Program
    {
        public enum Directions
        {
            Up,
            Down,
            Right,
            Left
        }

        public enum Orientation
        {
            North,
            South,
            East,
            West
        }

        public static void Main()
        {
            var direction = Directions.Right;
            Console.WriteLine($"Map view direction is {direction}");

            var orientation = direction switch
            {
                Directions.Up => Orientation.North,
                Directions.Right => Orientation.East,
                Directions.Down => Orientation.South,
                Directions.Left => Orientation.West,
            };
            Console.WriteLine($"Cardinal orientation is {orientation}");
        }
    }
}
