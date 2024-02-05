using System;
class Program{
    static void Main(){
        string a = @"C:\tUsers\Username\Documents";
        string b = "C:\tUsers\\Username\\Documents";

        Console.WriteLine(a);   
        Console.WriteLine(b);
    }
}