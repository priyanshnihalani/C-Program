using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList(); // Creating an ArrayList

        Console.WriteLine($"Initial Capacity: {list.Capacity}"); // Output initial capacity

        // Adding elements to the ArrayList
        list.Add("Apple");
        list.Add("Banana");
        list.Add("Orange");

        // Output current capacity after adding elements
        Console.WriteLine($"Current Capacity after adding 3 elements: {list.Capacity}");

        // Adding more elements to the ArrayList
        //list.Add("Grapes");
        list.Add("Watermelon");
        list.Add("Mango");
        list.Add("Pineapple");

        // Output current capacity after adding more elements
        Console.WriteLine($"Current Capacity after adding 4 more elements: {list.Capacity}");
    }
}
