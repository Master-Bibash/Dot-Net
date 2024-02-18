using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Example{
     class ExampleTwo
     {
          static void Main(String[] args)
          {
               Dictionary<string, int> stuendtAges = new Dictionary<string, int>();

               //add in key and value
               // Console.WriteLine("Add key");
               stuendtAges.Add("Pratyush", 19);

               stuendtAges["Bibash"] = 20;
               stuendtAges["A"] = 90;
               stuendtAges["B"] = 40;
               stuendtAges["Ram"] = 70;
               //when we work on keys only not values we use Icollection
               ICollection<string> keys = stuendtAges.Keys; //ICollection build in class //string is our key



               //remove
               stuendtAges.Remove("A");

               for (int i = 0; i < stuendtAges.Count; i++)
               {
                    //print with key and value
                    Console.WriteLine($"student name is {stuendtAges.ElementAt(i).Key} and age is {stuendtAges.ElementAt(i).Value}");


               }

               Queue<string> queue = new Queue<string>();
               queue.Enqueue("biabsh");
               queue.Enqueue("P");
               queue.Enqueue("Q");
               queue.Enqueue("R");
               //deque delets the value of queue
               queue.Dequeue();
               //peek displays the value which is inside of queue
               Console.WriteLine(queue.Peek());

               Stack<string> stack = new Stack<string>();
               stack.Push("M");
               stack.Push("N");
               stack.Push("O");
               stack.Push("P");
               //pop deletes the last data inserted
               stack.Pop();

               //peek displays the message
               Console.WriteLine(stack.Peek());







          }

     }

}
