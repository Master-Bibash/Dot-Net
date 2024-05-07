//question four dot net

using System;

namespace DayFour.Assignment
{
     class QuestionFour
     {
          static void Main(string[] args)
          {
               const int NumStudents = 3;

               // Declare and initialize the jagged array
               int[][] studentGrades = new int[NumStudents][];

               // Initialize variable to store the highest score
               int highestScore = int.MinValue;

               // Input grades from the user for each student
               for (int i = 0; i < NumStudents; i++)
               {
                    Console.Write($"Enter the number of grades for student {i + 1}: ");
                    if (!int.TryParse(Console.ReadLine(), out int numGrades) || numGrades <= 0)
                    {
                         Console.WriteLine("Invalid input. Please enter a positive integer for the number of grades.");
                         return;
                    }

                    // Initialize the inner array
                    studentGrades[i] = new int[numGrades];

                    // Input grades for the inner array
                    for (int j = 0; j < numGrades; j++)
                    {
                         Console.Write($"Enter grade {j + 1} for student {i + 1}: ");
                         if (!int.TryParse(Console.ReadLine(), out studentGrades[i][j]))
                         {
                              Console.WriteLine("Invalid input. Please enter a valid integer for the grade.");
                              return;
                         }

                         // Update the highest score if needed
                         if (studentGrades[i][j] > highestScore)
                         {
                              highestScore = studentGrades[i][j];
                         }
                    }
               }

               // Display the student grades, average, and highest score
               Console.WriteLine("Student Grades, Average, and Highest Score:");
               for (int i = 0; i < studentGrades.Length; i++)
               {
                    Console.Write($"Student {i + 1} Grades: ");
                    int sum = 0;

                    for (int j = 0; j < studentGrades[i].Length; j++)
                    {
                         Console.Write(studentGrades[i][j] + " ");
                         sum += studentGrades[i][j];
                    }

                    double average = (double)sum / studentGrades[i].Length;
                    Console.WriteLine($"  Average: {average:F2}");
               }

               Console.WriteLine($"Highest Score: {highestScore}");

               Console.WriteLine("Press any key to exit...");
               Console.ReadKey();
          }
     }
}