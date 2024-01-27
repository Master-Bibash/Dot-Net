using System;
namespace DayThree.Assignment
{
     class QuestionEight
     {
          static void Main(string[] args)
          {
               Random rnd = new Random();
               int num = rnd.Next(1, 9);
               Console.WriteLine("Guess the number");
               do
               {
                    int n = int.Parse(Console.ReadLine());
                    if (n==num)
                    {
                         Console.WriteLine("Correct! You guessed the number ");
                         break;
                         
                    }else{
                         Console.WriteLine("Incorrect.Try again");
                    }

                    
               } while (true);
          }
     }
}