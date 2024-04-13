using System;

namespace DayFour.Assignment
{
     class QuestionOne
     {
          static void Main(string[] args)
          {
               int[][] grades = new int[3][]; // Assuming 3 students, each with a variable number of grades

        // Initialize individual arrays for each student
        grades[0] = new int[] { 90, 85, 88 }; // Grades for student 1
        grades[1] = new int[] { 78, 92, 80, 87 }; // Grades for student 2
        grades[2] = new int[] { 85, 79, 95, 88, 91 }; // Grades for student 3

        // Accessing and printing grades
        Console.WriteLine("Grades for Student 1: " + string.Join(", ", grades[0]));
        Console.WriteLine("Grades for Student 2: " + string.Join(", ", grades[1]));
        Console.WriteLine("Grades for Student 3: " + string.Join(", ", grades[2]));
    }
}
              
                       

             
          }
     

