using System;

class Extra{
    public static int count = 0;
    public Extra(){
        count++;
    }
}
class Program{
    static void Main()
    {
        Extra extra = new Extra();
        Extra extra1 = new Extra();

        Console.WriteLine(Extra.count);
    }
}