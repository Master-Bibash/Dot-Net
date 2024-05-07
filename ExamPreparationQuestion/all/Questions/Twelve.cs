//binary operator
using System;
using System.Numerics;
namespace Questions
{
     class complex{

         public int number1;
          int number2;
          
          public complex(int a ,int b){
               number1 = a;
               number2 = b;
          }
          public void show(){
               Console.WriteLine($"the data {number1} and {number2}");

          }
          public static complex operator +(complex num1,complex num2){
             
               int sum1=num1.number1+ num1.number2;

               int sum2 = num2.number1+ num2.number2;

               return new complex(sum1, sum2);


          }
     }

    

     class Twelve
     {
          public static void Main(string[] args)
          {
               complex c1 = new complex(10, 20);
               c1.show();
               complex c2 = new complex(10, 20);
               complex sum = c1 + c2;
               sum.show();







          }


     }





}
