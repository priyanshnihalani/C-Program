using System;

class Program{
    static void Main(){
        int []numbers = {10, 20, 30};
        ref int second = ref numbers[1];
        Console.WriteLine(second);
        second = 50;
        Console.WriteLine(second);
    }
}