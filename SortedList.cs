using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Creating a SortedList
        SortedList sortedList = new SortedList();

        // Adding elements to the SortedList
        sortedList.Add("C", "C Programming Language");
        sortedList.Add("Java", "Java Programming Language");
        sortedList.Add("Python", "Python Programming Language");
        sortedList.Add("JavaScript", "JavaScript Programming Language");

        // Displaying elements of the SortedList
        Console.WriteLine("SortedList elements:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Removing an element
        sortedList.Remove("Java");

        // Displaying elements after removal
        Console.WriteLine("\nSortedList elements after removal:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Checking if a key exists
        Console.WriteLine("\nDoes 'Python' exist in the SortedList?");
        Console.WriteLine(sortedList.ContainsKey("Python"));

        // Clearing the SortedList
        sortedList.Clear();

        // Displaying elements after clearing
        Console.WriteLine("\nSortedList elements after clearing:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
