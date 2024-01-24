using System;

class Program
{
    static void Main()
    {
        int decimalLiteral = 42;
        int hexLiteral = 0x3B;
        int binaryLiteral = 0b101010;

        // Octal literals are available starting from C# 7.2
        int octalLiteral = 0123;

        long longLiteral = 123L;
        uint unsignedLiteral = 123U;
        ulong unsignedLongLiteral = 123UL;

        int underscoredLiteral = 1_000_000;

        Console.WriteLine($"Decimal: {decimalLiteral}");
        Console.WriteLine($"Hexadecimal: {hexLiteral}");
        Console.WriteLine($"Binary: {binaryLiteral}");
        Console.WriteLine($"Octal: {octalLiteral}");
        Console.WriteLine($"Long: {longLiteral}");
        Console.WriteLine($"Unsigned Int: {unsignedLiteral}");
        Console.WriteLine($"Unsigned Long: {unsignedLongLiteral}");
        Console.WriteLine($"Underscored Literal: {underscoredLiteral}");
    }
}
