using System;
namespace DaySix.Example{
     class QuestionFive{
          static void Main(string[] args)
          {
               C c = new C();
               c.sum(3, 5);

          }
     }
}

class A{
     public virtual void sum(int a,int b){
          Console.WriteLine("sum of a+ b from a is "+(a+b));
     }
     // public void mul(int a,int b)
     
}

class B : A {
     public override void sum(int a, int b)
     {
          Console.WriteLine("a + b from class b is "+(a+b));
     } 


}

class C:B{
    //     public override void sum(int a, int b)
    //     {
    //           Console.WriteLine("sum from class c is " + (a + b));
    //     }
    public override void sum(int a, int b)
    {
     //base calles parent of object here the 
        base.sum(a, b);
    }
}