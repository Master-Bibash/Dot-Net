using System;
namespace DaySix.Example{
     class Car
     {
          public string color = "red";
          int speed=20;

          //making method
          public void carinfo(){
               Console.WriteLine($"The car is {color} and has the speed of {speed} ");
          }

        


         
     }
     class Person
     {
          public String name;
          public Person()
          {
               name = "Biabsh";
          }
     }
     class student{
          String nam;
          public student(String name){
               nam = name;
          }
          public void getname(){
               Console.WriteLine($"name is {nam}");
          }
     }
     class QuestionOne
     {
          static void Main(string[] args){
               Car maruti=new Car();
               maruti.carinfo();
               Person bibash = new Person();
               Console.WriteLine(bibash.name);
               student stn = new student("Bikash");
               stn.getname();
               // Console.WriteLine();
               // Console.WriteLine();

        
          }
     }
   
}
