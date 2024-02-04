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
    public string this[string nm, int flag]
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
        indexer["Hello1" ,1] = "World";
        Console.WriteLine(indexer[0] + " " + indexer["Hello1", 1]);
    }
}