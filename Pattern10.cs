// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i, j, k=1;
        for(i=1; i<=4; i++)
        {
            for(j=1; j<=i; j++)
            {
                Console.Write(k);
                k++;
            }
            Console.WriteLine();
        }
    }
}