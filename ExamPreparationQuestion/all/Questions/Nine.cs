using System;
namespace Questions

{
     public class P
     {
      public virtual void speak(){
               Console.WriteLine("Hello im a cloth");
      }   

     }
     class Shirt : P
     {
          public override void speak(){
               // Console.WriteLine("I am a shirt");
          }
         

     }

     class Nine
     {
          public static void Main(string[] args)
          {
               Shirt s = new Shirt();
               s.speak();
               
          }


     }





}
