using System;

namespace DayFour.Assignment
{
     class QuestionTwo
     {
          static void Main(string[] args)
          {
               const int NumStudents = 3;

               // Declare and initialize the jagged array
               int[][] studentScores = new int[NumStudents][];

               // Input scores from the user for each student
               for (int i = 0; i < NumStudents; i++)
               {
                    Console.Write($"Enter the number of scores for student {i + 1}: ");
                    if (!int.TryParse(Console.ReadLine(), out int numScores) || numScores <= 0)
                    {
                         Console.WriteLine("Invalid input. Please enter a positive integer for the number of scores.");
                         return;
                    }

                    // Initialize the inner array
                    studentScores[i] = new int[numScores];

                    // Input scores for the inner array
                    for (int j = 0; j < numScores; j++)
                    {
                         Console.Write($"Enter score {j + 1} for student {i + 1}: ");
                         if (!int.TryParse(Console.ReadLine(), out studentScores[i][j]))
                         {
                              Console.WriteLine("Invalid input. Please enter a valid integer for the score.");
                              return;
                         }
                    }
               }

               // Display the student scores
               Console.WriteLine("Student Scores:");
               for (int i = 0; i < studentScores.Length; i++)
               {
                    Console.Write($"Student {i + 1} Scores: ");
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                         Console.Write(studentScores[i][j] + " ");
                    }
                    Console.WriteLine();
               }
          }
     }
}
