using System;

namespace Possibities
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; 
            int[] arr = new int[] {
                0,0,0
            };
            for (int i = 0; i < 10; i++)
            {
                arr[0] = i;
                
                for (int j = 0; j < 10; j++)
                {
                    arr[1] = j;
                    
                    for (int k = 0; k < 10; k++)
                    {
                        arr[2] = k;
                        Console.WriteLine(arr[0] + ":" + arr[1] + ":" + arr[2]);
                        counter++; 
                    }
                }
            }
            Console.WriteLine($"count of the possibilities 000-999  :{counter}");
            
        }
    }
}
