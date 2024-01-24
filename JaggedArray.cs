using System;
class JaggedArray{
    static void Main()
    {
        int[][] arr = new int[3][];
        // Initialize the first row of jagged array with 5 elements.
        arr[0] = new int[]{12, 34, 45, 56, 55};
        arr[1] = new int[]{23, 45, 46, 64};
        arr[2] = new int[]{26, 98, 93, 25, 23};
        
        // Console.WriteLine(arr.Length);
        // Console.WriteLine(arr[0].Length);
        for(int i=0; i<arr.Length; i++)
        {
            for(int j=0; j<arr[i].Length; j++)
            {
                Console.Write($" {arr[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}