using System;

class Program{
    static void Main(){
        int sum = AddNumber(12, 34, 45, 53, 23, 55, 21);
        Console.WriteLine(sum);
    }
    static int AddNumber(params int[] Listnumbers){
        int total = 0;
        foreach (int i in Listnumbers)
        {
            total = total + i;
        }
        return total;
    }
}