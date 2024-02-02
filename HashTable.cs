using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Creating a HashTable
        Hashtable hashTable = new Hashtable();

        // Adding elements to the HashTable
        hashTable.Add("C", "C Programming Language");
        hashTable.Add("Java", "Java Programming Language");
        hashTable.Add("Python", "Python Programming Language");
        hashTable.Add("JavaScript", "JavaScript Programming Language");

        // Displaying elements of the HashTable
        Console.WriteLine("HashTable elements:");
        foreach (DictionaryEntry entry in hashTable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Removing an element
        hashTable.Remove("Java");

        // Displaying elements after removal
        Console.WriteLine("\nHashTable elements after removal:");
        foreach (DictionaryEntry entry in hashTable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Checking if a key exists
        Console.WriteLine("\nDoes 'Python' exist in the HashTable?");
        Console.WriteLine(hashTable.ContainsKey("Python"));

        // Clearing the HashTable
        hashTable.Clear();

        // Displaying elements after clearing
        Console.WriteLine("\nHashTable elements after clearing:");
        foreach (DictionaryEntry entry in hashTable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
