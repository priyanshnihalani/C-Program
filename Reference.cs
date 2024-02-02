using System;

class Program{
    static void Main()
    {
        int length = 10;
        int width = 20;
        int area;
        int perimeter;
        rectangle(length, width, out area, out perimeter);
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);

        int number = 10;
        AddNumber(number);
        Console.WriteLine(number);
        AddNumber(ref number);
        Console.WriteLine(number);
    }
    static void AddNumber(int number){
        number++;
    }
    static void AddNumber( ref int number){
        number++;
    }
    public static void rectangle(int length, int width, out int area, out int perimeter){
        area=length*width;
        perimeter = 2 * (length + width);
    }
}