//virtual and dynamic example

using System;

namespace Questions
{
     class Shape{
          public virtual void Draw(){
               Console.WriteLine("Drawing a shape");
          }

     }
     class Circle : Shape{
        public override void Draw()
        {
               Console.WriteLine("Drawing a circle.");
          }
    }




     class Two
     {
          
               

          static void Main(string[] args)
          {
               Shape shape = new Shape();
               shape.Draw();

               Circle circle =new Circle();
               circle.Draw();

               dynamic dynamicshape = new Circle();
               dynamicshape.Draw();
               

          }
     }




}