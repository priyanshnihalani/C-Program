using System;

public class Class1
{
	static void Main()
	{
		int no, i, j;
		for(i = 1; i <= 4; i++)
		{
			no = i;
			for(j = 1; j <= i; j++)
			{
				Console.Write(" "+no);
				no = no + 4 - j;
			}
			Console.WriteLine();
		}
	}
}
