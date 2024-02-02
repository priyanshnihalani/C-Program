using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Creating an ArrayList
        ArrayList arrayList = new ArrayList();

        // Adding elements to the ArrayList
        arrayList.Add("C#");
        arrayList.Add("Java");
        arrayList.Add("Python");
        arrayList.Add("JavaScript");

        // Displaying elements of the ArrayList
        Console.WriteLine("ArrayList elements:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Inserting an element at a specific index
        arrayList.Insert(2, "C++");

        // Displaying elements after insertion
        Console.WriteLine("\nArrayList elements after insertion:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Removing an element
        arrayList.Remove("Java");

        // Displaying elements after removal
        Console.WriteLine("\nArrayList elements after removal:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Clearing the ArrayList
        arrayList.Clear();

        // Displaying elements after clearing
        Console.WriteLine("\nArrayList elements after clearing:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}
