using System;
namespace DaySix.Example
{
     class VSI
     {
          static void Main(string[] args)
          {
               Polymorphism ph = new Polymorphism();
               ph.sum(1, 2);
               ph.sum(1, 2, 3);
               ph.sum(1, 2, 3, 4);

          }

     }


     class Polymorphism
     {


          public void sum(int a, int b)
          {
               Console.WriteLine(a + b);
          }
          //this is method overlaoding we make same method name but different parameter
          public void sum(int a, int b, int c)
          {
               Console.WriteLine(a + b + c);
          }
          public void sum(int a, int b, int c, int d)
          {
               Console.WriteLine(a + b + c + d);
          }
     }
}