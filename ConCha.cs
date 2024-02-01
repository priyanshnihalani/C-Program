using System;
public class MyClass
{
    private int myField;

    // Parameterized constructor
    public MyClasks(int initialValue)
    {
        myField = initialValue;
        Console.WriteLine(myField);
    }

    // Default constructor that calls the parameterized constructor
    public MyClass() : this(42)
    {
        
    }
}
class Program{
    static void Main()
    {
        MyClass myClass = new MyClass();

    }
}