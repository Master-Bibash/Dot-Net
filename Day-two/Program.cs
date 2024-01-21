using System;
using System.Diagnostics;

class Program
{
     static void Main(string[] args)
     {
          Console.WriteLine("Enter the number of rows");
          int rows = int.Parse(Console.ReadLine());

          Console.WriteLine("Enter number of columns");
          int cols = int.Parse(Console.ReadLine());

          //create a matrix
          //making a 2d array we use [,] for one-dimensional we use int[] array=new int[]
          int[,] matrix = new int[rows, cols];

          //step-3 read values into matrix

          Console.WriteLine("Enter the values for the matrix");
          for (int i = 0; i < rows; i++)//rows

          {
               for (int j = 0; j <cols ;j++){
                    Console.Write("enter value for [{0},{1}:]", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
               }
         
      
                    
               }

               //Step-4 : Display the matrix
               for (int i = 0; i < rows; i++)//rows
               {
                    for (int j = 0; j < cols; j++)//columns
                    {
                    Console.Write("{0} ", matrix[i, j]);
                         
                    }
               Console.WriteLine();
                    
               }
          //This line waits for a key press before closing the console window. It allows you to see the output before the console window closes.
          Console.ReadKey();
   
               
          }


     }

