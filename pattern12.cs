using System;

class Program{
    static void Main(){
        int i, j, k=0;
        for(i=1; i<=5; i++)
        {
            if(i%2!=0)
            {
                for(j=1; j<=3; j++)
                {
                    k=k+1;
                    Console.Write(" "+k);
                }
            }
            else{
                int temp = k + 1;
                for(j=k+3;  j>=temp; j--){
                    k=k+1;
                    Console.Write(" " + j);
                }
            }
            Console.WriteLine();
        }   
    }

}