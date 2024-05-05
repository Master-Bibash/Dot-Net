using System;
namespace Questions

{

     class operator_overloading
     {
          int num1;
          int num2;
          public operator_overloading(int num1, int num2)
          {
               this.num1 = num1;
               this.num2 = num2;
          }
          public static operator_overloading operator -(operator_overloading numm)
          {
               numm.num1 = numm.num1 - numm.num1;
               numm.num2 = numm.num2 - numm.num2;
               return numm;

          }
          public void show()
          {
               Console.WriteLine($"number is {num1} and {num2}");
          }
     }


     class Elevan
     {
          public static void Main(string[] args)
          {
               operator_overloading op = new operator_overloading(10, 12);
               op.show();
               op = -op;
               op.show();




          }


     }





}
