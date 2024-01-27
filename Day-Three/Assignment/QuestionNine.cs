using System;

namespace DayThree.Assignment
{
     class QuestionNine
     {
          static bool IsPrime(int number)
          {
               if (number <= 1)
                    return false;

               for (int i = 2; i <= Math.Sqrt(number); i++)
               {
                    if (number % i == 0)
                         return false;
               }

               return true;
          }

          static int GenerateRandomPrime()
          {
               Random rnd = new Random();
               int randomNum;

               do
               {
                    randomNum = rnd.Next(1, 50); // Adjust the range as needed
               } while (!IsPrime(randomNum));

               return randomNum;
          }

          static void Main(string[] args)
          {
               int num = GenerateRandomPrime();
               Console.WriteLine($"Random prime number is {num}");
               Console.WriteLine("Guess the prime number");

               while (true)
               {
                    int n;

                    // Ensure user input is a prime number
                    while (true)
                    {
                         Console.WriteLine("Enter a prime number:");
                         if (int.TryParse(Console.ReadLine(), out n) && IsPrime(n))
                              break;
                         else
                              Console.WriteLine("Invalid input. Please enter a prime number.");
                    }

                    if (n == num)
                    {
                         Console.WriteLine("Correct! You guessed the prime number.");
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
