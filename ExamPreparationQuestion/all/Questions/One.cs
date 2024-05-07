using System;
//exmaple of implicit case and expicit case
namespace Questions
{
    class One{
          static void Main(String[] args)
          {
               int a = 5;
               long b = a;
               short z = (short)a;
               Console.Write(z.GetTypeCode());
               
          }
     }
     
}