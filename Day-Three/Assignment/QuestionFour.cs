using System;
namespace DayThree.Assignment
{
    class QuestionFour{
          static void Main(string[] args)
          {
               Console.WriteLine("Enter day");
               String day = Console.ReadLine().ToLower();
               switch(day)
               {
                    case "sunday":
                         Console.WriteLine("Its weekend");
                         break;
                    case "monday":
                         Console.WriteLine("Its weekday");
                         break;
                          case "tuesday":
                         Console.WriteLine("Its weekday");
                         break;
                          case "wednesday":
                         Console.WriteLine("Its weekday");
                         break;
                          case "thrusday":
                         Console.WriteLine("Its weekday");
                         break;
                          case "friday":
                         Console.WriteLine("Its weekday");
                         break;
                    case "saturday":
                         Console.WriteLine("Its weekend");
                         break;

                    default :
                         Console.WriteLine("please enter valid day");
                         break;  
                                      }

          }
     }
}