<<<<<<< HEAD
//operation add,sub,dev, using delegate and lamda ,
// for example calculate(10,20) should call all the funcion add sub mul
//remeber calculate is delegate


=======
>>>>>>> bd38d89bf5764c47949cdeb9ddd0431e17b8b4e9
using System.Security.Cryptography.X509Certificates;

namespace Example
{


     class Three
     {
<<<<<<< HEAD
          public delegate void Calculate(int a, int b);


          class Value
          {
               public void Add(int a, int b) => Console.WriteLine($"Addition result: {a + b}");
               public void Sub(int a, int b) => Console.WriteLine($"Subtraction result: {a - b}");
               public void Div(int a, int b) => Console.WriteLine($"Division result: {a / b}");
          }



          static void Main(string[] args)
          {
               Value cal = new Value();

               Calculate cpp = (a, b) =>
               {
                    cal.Add(a, b);
                    cal.Sub(a, b);
                    cal.Div(a, b);
               };

               cpp(10, 5);
=======
          public delegate void calculate(int a, int b);


          static void Main(String[] args)
          {
               
               
              

>>>>>>> bd38d89bf5764c47949cdeb9ddd0431e17b8b4e9
          }
     }
}

<<<<<<< HEAD
=======
//operation add,sub,dev, using delegate and lamda ,
// for example calculate(10,20) should call all the funcion add sub mul
//remeber calculate is delegate
>>>>>>> bd38d89bf5764c47949cdeb9ddd0431e17b8b4e9
