using System;

public class Pattern9
{
	static void Main()
	{
		int k = 0, i, j;
		for (i = 1; i <= 4; i++)
		{
			if (i % 2 == 0)
			{
				int temp = k+1;
				for (j = k+3; j >= temp; j--)
				{
						k++;
						Console.Write(j + " ");	
				}
				Console.WriteLine();
			}
			else
			{
				for(j = 1;j <= 3; j++)
				{
					k++;
					Console.Write(k + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
