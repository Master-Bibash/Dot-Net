using System;
namespace DaySeven.Two{
     class QuestionTwo{
          static void Main(String[] args){
               //method overloading
               Calculator cal = new Calculator();
               //integer
               Console.WriteLine($"interger sum is {cal.add(1, 2)}");
               Console.WriteLine($"interger difference is {cal.sub(1, 2)}");
               Console.WriteLine($"interger multiplication is {cal.mul(1, 2)}");
               Console.WriteLine($"interger division is {cal.div(4, 2)}");

               //double
               Console.WriteLine($"double sum is {cal.add(1.5, 2.9)}");
               Console.WriteLine($"double difference is {cal.sub(10/8, 2.1)}");
               Console.WriteLine($"double multiplication is {cal.mul(1.6, 2.9)}");
               Console.WriteLine($"double division is {cal.div(4.2, 2.4)}");



          }
          class Calculator{
               //addition
               public int add(int a,int b){
                    return a + b;
               }
               public double add(double a,double b){
                    return a + b;
               }
               //subtraction
               public int sub(int a,int b){
                    return a - b;
               }
               public double sub(double a,double b){
                    return a - b;
               }
               //multiplication
               public int mul(int a,int b){
                    return a * b;
               }
               public double mul(double a, double b){
                    return a* b;
               }
               //division
               public int div(int a, int b)
               {
                    if (b == 0)
                    {
                         return 0;
                    }
                    else
                    {
                         return a / b;
                    }
               }
               public double div(double a, double b)
               {
                    if (b==0){
                         return 0;
                    }else{
                         return a / b;
                    }

               }

          }
     }
}