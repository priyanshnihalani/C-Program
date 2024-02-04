using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var evenNumbers = numbers.Where(IsEven);

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
