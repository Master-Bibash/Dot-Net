//This is example of List
//List class is used to store and fetch elemenets.It can have duplicate elements.It is found in System.Collections.Generic namespace.

using System;
namespace DaySix.Example{
     class MyListExample{

        static void Main(string[] args){
               //creating a list of string
               var names = new List<String>();
               names.Add("Bibash");
               names.Add("Rmaesh");
               names.Add("Kalu");
               names.Add("Bibash");
               Console.WriteLine(names.Count);
               Console.WriteLine("Name list is ");
               foreach (String item in names)
               {
                         Console.WriteLine(item);
                    
               }

          

          }
     }
     

}