using System;



class Swap
{

     static void Main(String[] args)
     {
          // Prompt the user to enter the value for 'a'
          Console.WriteLine("Enter a value");
          int a = Convert.ToInt16(Console.ReadLine());

          // Prompt the user to enter the value for 'b'
          Console.WriteLine("Enter b value");
          int b = Convert.ToInt16(Console.ReadLine());

          // Swap the values of 'a' and 'b' without using a third variable
          a = a + b;    // Sum of 'a' and 'b' is stored in 'a'
          b = a - b;    // 'b' is updated to be the difference between the new 'a' and original 'b'
          a = a - b;    // 'a' is updated to be the difference between the original sum and new 'b'

          // Display the swapped values
          Console.WriteLine($"Swapping a and b values, we get {a} and {b}");
     }
}
