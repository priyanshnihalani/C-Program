using System; 
using System.Collections; 
class Program { 
  
    // Driver code 
    public static void Main() 
    { 
  
        // Creating a Stack 
        Stack myStack = new Stack(); 
  
        // Inserting the elements into the Stack 
        myStack.Push("1st Element"); 
        myStack.Push("2nd Element"); 
        myStack.Push("3rd Element"); 
        myStack.Push("4th Element"); 
        myStack.Push("5th Element"); 
        myStack.Push("6th Element"); 
  
        Console.Write("Total number of elements in the Stack are : " + myStack.Count); 

        myStack.Pop();
        
        Console.Write("Total number of elements in the Stack are : " + myStack.Count); 

    }
}