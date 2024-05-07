//jagged array
using System;

namespace Questions
{
     class Two
     {
          static void Main(String[] args)
          {
               int[][] array = new int[2][]{
                 new int[2]{1,2},
                 new int[3]{1,2,3}
               };

               foreach (int[] items in array)
               {
                    foreach (int item in items )
                    {
                         Console.Write($"{item}");
                         
                    }
                    Console.WriteLine();
                    
               }

          }
     }
}