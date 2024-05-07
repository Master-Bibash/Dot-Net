using System;

public delegate int MyDel(int a, int b);

class MathOperations
{
     public int Add(int a, int b)
     {
          return a + b;
     }

     public int Subtract(int a, int b)
     {
          return a - b;
     }

     public int Multiply(int a, int b)
     {
          return a * b;
     }
}

class Sixteen
{
     static void Main(String[] args)
     {
          MathOperations math = new MathOperations();

          // Create an anonymous delegate and assign it to variable 'm'
          MyDel m = delegate (int a, int b)
          {
               Console.WriteLine("Anonymous delegate result: " + (a + b));
               return a + b;
          };

          // Create a delegate 'del' and point it to the 'Add' method
          MyDel del = new MyDel(math.Add);

          // Add the anonymous delegate 'm' to 'del' using the += operator
          del += m;

          // Add the 'Multiply' method to 'del' using the += operator
          del += math.Multiply;

          // Invoke the multicast delegate, which will call 'Add', the anonymous delegate, and 'Multiply'
          int result = del(3, 2);
          Console.WriteLine("Final result: " + result);
     }
}
