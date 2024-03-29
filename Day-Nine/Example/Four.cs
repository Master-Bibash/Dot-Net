//arraylist example

using System.Collections;

namespace Example


{


     class Four{
          static void Main(String[] args){
               ArrayList myList = new ArrayList();
               myList.Add("bi");
               myList.Add("kas");
               myList.Add("ma");
               myList.Add(new List<int>{1,2,3,4,5});

              foreach (var item in myList)
              {
               if (item is List<int>)
               {
                    foreach (var newList in (List<int>) item)
                    {
                              Console.WriteLine(newList);
                         
                    }
                    
               }
               
              }

          }
     }
     
}