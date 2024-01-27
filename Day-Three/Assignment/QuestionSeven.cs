using System;

namespace DayThree.Assignment
{
     class QuestionSeven
     {
          static void Main(string[] args)
          {
               Random rnd = new Random();
               int num = rnd.Next(1, 9);
               Console.WriteLine("Guess the number");

               while (true)
               {
                    int n = int.Parse(Console.ReadLine());

                    if (n == num)
                    {
                         Console.WriteLine("Correct! You guessed the number.");
                         break; // Exit the loop once the correct guess is made
                    }
                    else
                    {
                         Console.WriteLine("Incorrect. Try again.");
                    }
               }
          }
     }
}
