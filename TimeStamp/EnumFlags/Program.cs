using System;
using System.Text;

namespace EnumFlags
{
    [Flags]
    public enum Days
    {
        None = 0b_0000_0000,        // 0
        Monday = 0b_0000_0001,      // 1
        Tuesday = 0b_0000_0010,     // 2
        Wednesday = 0b_0000_0100,   // 4
        Thursday = 0b_0000_1000,    // 8
        Friday = 0b_0001_0000,      // 16
        Saturday = 0b_0010_0000,    // 32
        Sunday = 0b_0100_0000,      // 64
        Вихідні = Saturday | Sunday
    }

    public class FlagsEnumExample
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
            Console.WriteLine(meetingDays);
            
            Days workingFromHomeDays = Days.Thursday | Days.Friday;
            Console.WriteLine($"Приєднуйтесь до ZOOM конференції в {meetingDays & workingFromHomeDays}");

            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Чи є зустріч у вівторок: {isMeetingOnTuesday}");

            var a = (Days)18;
            Console.WriteLine(a);
        }
    }
}