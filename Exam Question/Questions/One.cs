//using dyanmic in c#
//We use 'dynamic' to store the result because we don't know its type until the method is actually called. 

using System;

namespace Questions
{
    



     class One
     {
          static dynamic GetData(bool condition)
          {
               if (condition)
               {
                    return 10; // Return an integer if condition is true
               }
               else
               {
                    return "Hello"; // Return a string if condition is false
               }
          }

          static void Main(string[] args)
          {
               bool somecondition = false;
               // Now you can use 'result' without knowing its exact type until runtime

               dynamic result = GetData(somecondition);
               Console.WriteLine(result);

          }
     }
     



}