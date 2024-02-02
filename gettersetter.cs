using System;
public class Person
{
    // Auto-implemented property
    public string Name { get; set; }

    // Auto-implemented property with private setter
    public int Age { get;  set; }

    // Auto-implemented property with initialization
    public string Address { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        // Setting the Name property
        person.Name = "John Doe";
        string name = person.Name;

        // Setting the Age property (private set)
        // This is only possible within the Person class
        // person.Age = 30; // This will cause a compilation error

        // Getting the Age property
        person.Age = 19;
        int age = person.Age; // This is allowed

        // Getting the Address property
        person.Address = "Rajkot";
        string address = person.Address; // Returns "Unknown"
        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(address);
    }
}
