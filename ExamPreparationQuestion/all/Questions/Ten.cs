using System;
namespace Questions

{


     public class parent
     {

         public virtual void run(){
               Console.WriteLine("aaa");
          }
     }
     class child : parent
     {
         public override void run()
          {
               Console.WriteLine("aaall");
          }


     }

     class Ten
     {
          public static void Main(string[] args)
          {
               child c=new child();
               object s = "Hello";
               string v = s as string;
               bool same = v is object;
               parent p = c; //upcasting
               p.run();
               //upcasting means converting reference class to base class

               parent p1 = new child();
               child cha = (child)p1; //downcasting
               //upcasting is converting base class to reference class
               if (same)
               {
                    Console.WriteLine("same");
               }
               else
               {
                    Console.WriteLine("b");
               }

          }





     }
}