//binary operator
using System;
using System.Collections;
namespace Questions
{


  class mygeric<T>{
          private T data;
          public mygeric(T input){
               data = input;
          }
          public void display(){
               Console.WriteLine($" the daya us {data}");
          }
         public void shownum<T>(int op){
               Console.WriteLine($" op is {op}");
         }
  }



     class Fifteen
     {
          public static void Main(string[] args)
          {
               Dictionary<int, string> dist = new Dictionary<int, string>(5);
               dist.Add(1, "asd");
               Queue<int> a = new Queue<int>(4);
               a.Enqueue(1);
               Stack<int> stac = new Stack<int>(5);
               stac.Push(1);


               mygeric<int> my = new mygeric<int>(30);
               List<int> list = new List<int>(5);
               list.Add(1);
               ArrayList arrylist = new ArrayList();
               arrylist.Add(2);
               arrylist.Add("biabsd");
               
               my.display();
               my.shownum<int>(2);

             




          }


     }





}
