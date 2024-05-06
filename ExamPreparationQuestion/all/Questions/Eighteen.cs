using System;

namespace Questions
{
     // Delegate declaration

     class Eighteen
     {
          public static void Main(String[] args)
          {
               int a = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine(a);

               List<String> numbers = new List<String> { 
                    "bibash",
                    "kalaa",
                    "eeee",

               };
               var evenNumbers = from name in numbers where name.StartsWith("b") select name;

                       foreach (var item in evenNumbers)
                       {
                    {
                         Console.WriteLine(item);

                    }

               }
          }
     }

    

   
}
