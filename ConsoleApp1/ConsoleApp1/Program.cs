//Program to Print "Hello World"

using System;
class Program1
{
    public static void Main(string[] args)
    {
       /* Console.WriteLine("Hello World");
        Console.ReadLine(); */

        Console.Write("Enter Name: ");
        String name = Console.ReadLine();

        Console.WriteLine($"Welcome {name}");
    }
}