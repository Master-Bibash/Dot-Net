//binary operator
using System;
namespace Questions
{
     
class tatti{
     public virtual void show(){
               Console.WriteLine("tatti ae");

     }
}

class toiler: tatti{
     public void display(){
               base.show();
     }
}

     class Thirteen
     {
          public static void Main(string[] args)
          {

               toiler m = new toiler();
               m.display();




          }


     }





}
