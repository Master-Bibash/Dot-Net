// Overriding Practical Question:
// Task:
// Design a class hierarchy for a simple shape system.Create a base class Shape with the following methods:

// CalculateArea:

// Method signature: public virtual double CalculateArea()
// Calculates and returns the area of the shape.
// DisplayInfo:

// Method signature: public virtual void DisplayInfo()
// Displays general information about the shape.
// Create two derived classes, Circle and Rectangle, from the Shape class. Override the CalculateArea method in each derived class to provide specific implementations for calculating the area of a circle and a rectangle. Also, override the DisplayInfo method in each derived class to display shape-specific information.
using System;
using System.ComponentModel.DataAnnotations;
namespace DaySeven.Three {
     class QuestionThree {
          static void Main(String[] args) {
               Shape shape1 = new Circle(5);
               Shape shape2 = new Rectangle(2, 3);
               shape1.DisplayInfo();
               shape2.DisplayInfo();



          }
          class Shape {
               protected double area;
               public virtual double CalculateArea() {
                    return area;
               }
               public virtual void DisplayInfo() {

                    Console.WriteLine($"Area is {CalculateArea()}.");

               }
          }
          class Circle : Shape {

               private double radius;
               public Circle(double radius)
               {
                    this.radius = radius;
                    CalculateArea();
               }
            public override double CalculateArea()
            {
                    area = Math.PI * radius * radius;
                    return area;
            }
            public override void DisplayInfo()
            {
                    Console.WriteLine($"Area of the circle is {CalculateArea()}.");
               }



          }
          class Rectangle:Shape{
               private double width;
               private double height;
               public Rectangle(double width,double height){
                    this.width = width;
                    this.height = height;
                    CalculateArea();
               }
            public override double CalculateArea()
            {
                    area = width * height;
                    return area;


            }
            public override void DisplayInfo()
            {
                    Console.WriteLine($"Area of the rectangle is {CalculateArea()}.");

               }
          }

     }
}