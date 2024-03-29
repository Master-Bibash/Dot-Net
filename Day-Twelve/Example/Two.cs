//Here is a simple example that creates a array of integers. A LINQ query is used to return a var that stores the collection of returned data. Learn more: The var keyword in C#.

namespace Example
{
     class Two{
          static void Main(string[] args){
               int[] nums = new int[] { 0, 9, 21, 1, 4, 5, 6, 2, 4 };
               var res = from a in nums where a > 5 orderby a select a ;
               foreach(int i in res){
                    Console.WriteLine(i);
               }


          }
     }
     
}