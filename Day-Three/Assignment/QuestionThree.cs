using System;
namespace DayThree.Assignment{
     class QuestionThree{
          static void Main(string[] args){
               Console.WriteLine("enter grade of nepali");
               int n = int.Parse(Console.ReadLine());
               Console.WriteLine("enter grade of science");
               int s = int.Parse(Console.ReadLine());
               Console.WriteLine("enter grade of math");
               int m = int.Parse(Console.ReadLine());
               Console.WriteLine("enter grade of computer");
               int c= int.Parse(Console.ReadLine());
               Console.WriteLine("enter grade of economics");
               int e= int.Parse(Console.ReadLine());
               double avg = (n + s + m + c + e) / 5;
               char grade;
               if (avg >= 90)

                    Console.WriteLine("A");


               else if (avg >= 80)

                    Console.WriteLine("B");

               else if (avg >= 70)
               
                  Console.WriteLine("C");

               
               else if (avg >= 60)
                    Console.WriteLine("D");


               else

                    Console.WriteLine("E");


          }
              
     }
}