
using System;

namespace DayThree.Assignment
{
     class QuestionOne
     { 
          static void Main(string[] args)
          {
               Console.WriteLine("Entr vakue of a");
               int a = int.Parse(Console.ReadLine());
               Console.WriteLine("Entr vakue of b");

               int b = int.Parse(Console.ReadLine());

               Console.WriteLine($"b value is {b}");
               swap(ref a, ref b);
               Console.WriteLine($"value of a is {a} value of b is {b}");


               //method to swap
               void swap(ref int a, ref int b)
               {
                    a = a + b;//15
                    b=a-b;
                    a = a - b;
                    




               }



          }
     }
}




