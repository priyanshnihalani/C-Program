using System;
class pattern1
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++) {
            for(int j=5; j>=i; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

/*
54321
5432
543
54
5
*/