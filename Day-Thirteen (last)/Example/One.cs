using System;

namespace Example
{
     class One
     {
          static void Main(string[] args)
          {
               Number n = new Number(-5);

               Console.WriteLine($"value is {n.data}");
               n = --n;
               Console.WriteLine($"value is {n.data}");
          }
     }

     class Number
     {
          public int data;

          public Number(int n)
          {
               data = n;
          }

          // // Overloading the unary + operator
          public static Number operator +(Number num)
          {
               Console.WriteLine($"num value is ${num} and data is ${num.data}");
               num.data = +num.data;
               return num;
          }
          public static Number operator --(Number num){
               num.data = -num.data;
               return num;

          }
     }
}

// Overall, unary operator overloading helps you tailor the behavior of unary operators to suit the needs of your custom types, making your code more readable, maintainable, and domain-focused.

// In C#, when you overload a unary operator, you must define the operator as a static method inside your class. This static method is what provides the custom behavior for the unary operator. So, yes, defining the operator method is compulsory if you want to overload a unary operator for your class.

