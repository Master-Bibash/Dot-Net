// C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime.
// Delegates are especially used for implementing events and the call-back methods. All delegates are implicitly derived from the System.Delegate class.

namespace Example
{
     delegate void mydelegate(string name);
     class Name{
          public void name(String name){
               Console.WriteLine("name is " + name);
          }
     }
     class Two{
          static void Main(string[] args){
               Name n = new Name();
               mydelegate m = new mydelegate(n.name);
               m("Bibash");


          }
     }
     
     
}