using System;
using DaySeven.One;
namespace DaySeven.Five
{
//using sealed we cannot override the method more then once and also if the class is sealed we cannot inherit that class.
     class MainInherit{
          static void Main(String[] args){
               // First f = new First();
               // f.DisplayMsg();
               Third third = new Third();
               third.DisplayMsg();
               object[] arr = new object[]{
                    "bibash",
                    12345.232,
                    false
               };
               foreach (object item in arr)
               {
                    if (item is string)
                    {
                         Console.WriteLine($"this is a string {item}");    
                    }else if(item is double){
                         Console.WriteLine($"this is a int {item}");
                    }else if (item is bool){
                         Console.WriteLine($"This is bool value is {item}");
                    }
                    Console.WriteLine("unknown datatype");
                    
               }
               // object[] mixedData = new object();



          }
     }
     //using sealed we cannot inherit
       class Second 
     {
         public virtual void DisplayMsg(){
               Console.WriteLine("this is a message");
         }
     }
     class First:Second{
        public override void DisplayMsg()
        {
               Console.WriteLine("this is first method override");
        }

        public void DisplayInfo(){
               Console.WriteLine("This is from first");
          }


     }
     class Third:First{
          //we cannot use sealed more then once while overriding it .
         sealed public override void DisplayMsg(){
               base.DisplayMsg();
               Console.WriteLine("This is third and overridded");

          }
     }
     class Fourth: Third
     {
          // we cannot override the sealed method more then once
          //                                -------------------- -----------------
          // public override void DisplayMsg(){
          //      Console.WriteLine("this is a fourth overridded ");
          // }
     }
}