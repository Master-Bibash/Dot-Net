using System;
namespace Questions

{


abstract class animal{
          public abstract void sound();
     public  void sleep(){
               Console.WriteLine("animal sleeps");

     }

}
     class Dog : animal
    {
     public override void sound(){
               Console.WriteLine("animal makes sound");
     }
       
    }

    class Eight
     {
          public static void Main(string[] args)
          {
               Dog dog = new Dog();
               dog.sound();
          }


     }





}
