//binary operator
using System;
namespace Questions
{

public class parentclass{
          public parentclass(int a, int b){
               Console.WriteLine($"the  numnber is {a} and {b}");
          }

     
}
   class childclass : parentclass{
          public childclass(int x, int y) : base(x, y){
               Console.WriteLine($"num in child is {x} and {y}");
          }
          // parentclass p = new parentclass();

        
    }




     class Fourteen
     {
          public static void Main(string[] args)
          {
               new childclass(1, 2);

              




          }


     }





}
