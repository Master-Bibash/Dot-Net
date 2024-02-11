// Create a simple inheritance hierarchy for a library system. Design classes to represent different types of items in the library, including LibraryItem (base class), Book(derived class), and DVD(derived class). Each item in the library has a unique ID, a title, and can be checked out or returned.

// Base Class: LibraryItem

// Properties:
// Id(int): Unique identifier for the library item.
// Title (string): Title of the library item.
// IsCheckedOut (bool): Indicates whether the item is currently checked out.

// Derived Class: Book

// Additional Properties:
// Author(string): Author of the book.
// Pages (int): Number of pages in the book.
// Derived Class: DVD

// Additional Properties:
// Director(string): Director of the DVD.
// Duration (int): Duration of the DVD in minutes.
// Implement methods in each class to :

// Display information about the library item (ID, Title, IsCheckedOut).
// Check out the library item (set IsCheckedOut to true).
// Return the library item (set IsCheckedOut to false).

// Demonstrate the usage of these classes by creating instances of Book and DVD, displaying their information, checking them out, and returning them.
// [8:09 am, 05/02/2024] Santosh Sir Dot Net: Overloading Practical Question:
// Task:
// Design a class called Calculator that performs various mathematical operations. Implement overloaded methods for the following operations:

// Addition:

// Method signature: public int Add(int a, int b)
// Adds two integers and returns the result.
// Addition (Overload):

// Method signature: public double Add(double a, double b)
// Adds two doubles and returns the result.
// Subtraction:

// Method signature: public int Subtract(int a, int b)
// Subtracts the second integer from the first and returns the result.
// Subtraction (Overload):

// Method signature: public double Subtract(double a, double b)
// Subtracts the second double from the first and returns the result.
// Multiplication:

// Method signature: public int Multiply(int a, int b)
// Multiplies two integers and returns the result.
// Multiplication (Overload):

// Method signature: public double Multiply(double a, double b)
// Multiplies two doubles and returns the result.
// Division:

// Method signature: public int Divide(int a, int b)
// Divides the first integer by the second (assuming non-zero denominator) and returns the result.
// Division (Overload):

// Method signature: public double Divide(double a, double b)
// Divides the first double by the second (assuming non-zero denominator) and returns the result.
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
namespace DaySeven.One
{
     class QuestionOne
     {
          static void Main(string[] args)
          {
               // Create instances of Book and DVD
               Book book = new Book(101, "The Great Gatsby", "F. Scott Fitzgerald", 180);
               DVD dvd = new DVD(201, "Inception", "Christopher Nolan", 148);

               // Display information about the items
               Console.WriteLine("Before checking out:");
               Console.WriteLine("Book:");
               book.DisplayInfo();
               Console.WriteLine("\nDVD:");
               dvd.DisplayInfo();

               // Check out the items
               book.CheckOut();
               dvd.CheckOut();

               // Display information after checking out
               Console.WriteLine("\nAfter checking out:");
               Console.WriteLine("Book:");
               book.DisplayInfo();
               Console.WriteLine("\nDVD:");
               dvd.DisplayInfo();

               // Return the items
               book.Return();
               dvd.Return();

               // Display information after returning
               Console.WriteLine("\nAfter returning:");
               Console.WriteLine("Book:");
               book.DisplayInfo();
               Console.WriteLine("\nDVD:");
               dvd.DisplayInfo();
          }




     }
         
     }

