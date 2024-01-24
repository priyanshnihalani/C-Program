using System;
class pattern1
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++) {
            for (int k = 1; k <= i; k++)
            {
                Console.Write(" ");
            }
            for(int j=1; j<=5; j++)
            {
                if (i==1 || i==5 || j==1 || j==5)
                {
                    Console.Write(" *");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}
/*
* * * * * 
  *       *
    *       *
      *       *
        * * * * *
*/