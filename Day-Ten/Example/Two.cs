//lamda example
//C# Lambda Expression is a short block of code that accepts parameters and returns a value. It is defined as an anonymous function (function without a name). For example,

// num => num * 7

namespace Example
{
     class Two{
          static void Main(String[] args){
               var newSum = (int a, int b) =>
               {
                    var Sum = a + b;
                    return Sum;
               };
               var SquareNum = (int x) => x * x;
               Console.WriteLine($"the square is {SquareNum(3)}");


               Console.WriteLine($"the sum is {newSum(1, 2)}");
          }
     }
     
}