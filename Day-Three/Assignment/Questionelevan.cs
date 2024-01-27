using System;
namespace DayThree.Assignment{
     class Questionelevan
     {
          static void Main(string[] args){
          //label
          repeat:
               Console.WriteLine("enter number less than 10");
               int num = Convert.ToInt32(Console.ReadLine());
               if (num>=10)
               {
                    goto repeat;
                    
               }else{
                    Console.WriteLine(num + "is less than 10");
                    Console.ReadLine();
               }
          }
     }
}
