
using System;
//it is an example of list

namespace Example
{
     class One{
          static void Main(String[] args){
               List<int> numbers = new List<int> { 1, 3, 2, 4 };
               numbers.Add(8);
               numbers.Add(10);
               numbers.Sort();
               numbers.Reverse();
               numbers.RemoveAt(1);
               numbers.Clear();
              
               foreach (int item in numbers)
              {
                    Console.WriteLine(item);

               }

          }
     }
}