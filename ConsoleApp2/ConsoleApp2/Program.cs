using System;
class Program
{
    public static void Main(string[] args)
    {
        int i = 0;
        int[] a;
        while (true)
        {
            Console.Write("Enter Number: ");
            a[i] = Convert.ToInt32(Console.ReadLine());
            if (a[i] == 0 )
            {
                break;
            }
        }
    }
}