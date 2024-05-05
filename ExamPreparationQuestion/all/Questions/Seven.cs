using System;
namespace Questions

{
    

    class A{
         public int num = 10;
    }
    class B:A{
          A a = new A();
          public void num(){
               Console.WriteLine(a.num);
              
          }
    }
    
     class Seven
     {
          public static void Main(string[] args)
          {
               B b = new B();
               b.num();








          }


     }

   



}
