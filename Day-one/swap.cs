using System;

namespace Swap{
     class Swap
     {
          static void Main(String[] args)
          {
               Console.WriteLine("enter a value");
               int a = Convert.ToInt16(Console.ReadLine());
               Console.WriteLine("enter b value");
               int b = Convert.ToInt16(Console.ReadLine());
               a = a + b;
               b = a - b;
               a=a-b;

               // Console.WriteLine("Swapping a and be we get of a is {0} and b i s {1}", a,b);
               Console.WriteLine($"swapping a and b value we get {a} and {b}");
          }
     }

}