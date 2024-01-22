
using System;

namespace DayThree.Assignment
{
     class QuestionOne
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Enter the year");
               int year=int.Parse(Console.ReadLine());
               if(year%4==0){
                    Console.WriteLine("Leap year");

               }else{
                    Console.WriteLine("Not a leap year");
               }

               // switch (year)
               // {
               //      case (year%4==0):
               //      Console.WriteLine("This is a leap year");

               //      case (year%4!=0):
               //      Console.WriteLine("Not a leap year");

                    
               //      default:
               //      Console.WriteLine("Please enter valid year");
               // }
               // Console.ReadKey();


          }
     }
}


// namespace DayThree.Assignment2
// {
//      class QuestionTwo
//      {
//           static void Main(string[] args)
//           {
//                Console.WriteLine("Enter the year two");


//           }
//      }
// }


