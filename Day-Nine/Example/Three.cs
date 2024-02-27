using System;
using System.Collections.Generic;



namespace Example
{
     delegate void Dele1(int x);

     class AddDele{
          public void  takeValue(int p){
               Console.Write($"Roll number is {p} ");
          }
          public void takeCast(int m){
               Console.Write($".Also we have House number is Calofornia 123{m}");
          }
     }
     class Three{
          static void Main(String[] args){
               AddDele fun = new AddDele();
               Dele1 d1 = new Dele1(fun.takeValue);
               Dele1 d2 = new Dele1(fun.takeCast);
               d1 += d2;
               d1(1);
            
             

            

          }
     }
     
}