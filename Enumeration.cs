using System;

enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
[Flags]
enum MyFlags
{
    None = 0,
    Flag1 = 1,
    Flag2 = 2,
    Flag3 = 4,
    Flag4 = 8,
    All = Flag1 | Flag2 | Flag3 | Flag4
}
class Enumeration
{
    static void Main()
    {
        // Days today = Days.Monday;
        // Console.WriteLine("Today is: " + today);

        // foreach (Days day in Enum.GetValues(typeof(Days)))
        // {
        //     Console.WriteLine(day);
        // }

        // int dayValue = (int)Days.Monday;
        // Days newDay = (Days)dayValue;

        // Console.WriteLine("\nNew Day Value: {0}", newDay);

        // string dayName = Enum.GetName(typeof(Days), 3);
        // Console.WriteLine(dayName);

        MyFlags combination = MyFlags.Flag1 | MyFlags.Flag2;
        Console.WriteLine(combination);
    }
}
