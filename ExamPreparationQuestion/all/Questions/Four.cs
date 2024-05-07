using System;
namespace Questions

{
     class Four
     {
          public static void Main(string[] args)
          {
               Car c = new Car("bibash", "karki", 1111);
               c.display();

               // Force garbage collection
               GC.Collect();
               GC.WaitForPendingFinalizers();
          }

          ~Four()
          {
               Console.WriteLine("Destructor is called");
          }
     }

     public class Car
     {
          string make;
          string model;
          int year;

          public Car()
          {
               make = "Default";
               model = "123";
               year = 2222;
          }

          public Car(string make, string model)
          {
               this.make = make;
               this.model = model;
          }

          public Car(string make, string model, int year)
          {
               this.make = make;
               this.model = model;
               this.year = year;
          }

          public void display()
          {
               Console.WriteLine($"Model is {model}, year is {year}");
          }

          ~Car()
          {
               Console.WriteLine("Destructor is called");
          }
     }
}