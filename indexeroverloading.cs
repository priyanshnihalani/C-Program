using System;
class Indexer{
    private string[] word = new string[2];

    public string this[int flag]
    {
        get{
            string temp = word[flag];
            return temp;
        }
        set{
            word[flag] = value;
        }
    }
    public string this[double flag]
    {
        get{
            string temp = word[flag];
            return temp;
        }
        set{
            word[flag] = value;
        }
    }
}
class Program{
    static void Main(){
        Indexer indexer = new Indexer();
        indexer[0] = "Hello";
        indexer[1.0] = "World";
        Console.WriteLine("$ Integer args {indexer[0]} and Double args {indexer[1.0]}");
    }
}