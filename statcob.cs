using System;
class MyClass
{
    // Static constructor

    // Other members
    public static void SomeMethod()
    {
        Console.WriteLine("Static method called");
    }
    static MyClass()
    {
        SomeMethod();
        Console.WriteLine("Static constructor called");
    }
}
class Program{
    static void Main()
    {
        new MyClass();
        // MyClass.SomeMethod();
    }
}
