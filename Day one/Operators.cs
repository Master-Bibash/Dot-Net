using System;



     class Operators
     {
         
               static void Main(string[] args)
               {
                    //addition
                    int a ;
                    int b ;
                    Console.WriteLine("enter a value");
                     a = Convert.ToInt16(Console.ReadLine());
                     Console.WriteLine("Enter b value");
                     b = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("The sum of a and b is {0}", a + b);

                     //subtraction
                     Console.WriteLine("Differenece of a and b is {0} ", a - b);

                     //mulliplication
                     Console.WriteLine($"multiplication of {a} and {b} is " + a * b);

                     //Division
                     Console.WriteLine("Division of a and b is {0}",a/b);


               }
          

     }
