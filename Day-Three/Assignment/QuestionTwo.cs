
using System;

namespace DayThree.Assignment
{
     class QuestionTwo
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Enter the year");
               int year = int.Parse(Console.ReadLine());
               if (year % 4 == 0)
               {
                    Console.WriteLine("Leap year");

               }
               else
               {
                    Console.WriteLine("Not a leap year");
               }



          }
     }
}




