using System;
class RefExample
{
     static void Main(string[] args)
     {
          int? number = 30;
          sum(ref number);

          Console.WriteLine(number);




     }

     static void sum(ref int? value)
     {
          value = value + 10;
     }
}