using System;
class pattern1
{
    static void Main()
    {
        for (int i = 5; i >= 1; i--) {
            for(int j=1; j<=i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

/*
12345
1234
123
12
1
*/