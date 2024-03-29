namespace Example
{
     class MethodCollections
     {
          public static void printName()
          {
               Console.WriteLine("My name is Khan");
          }
          public static void Print(String name){
               Console.WriteLine("name is ", name);
          }
          public static void PrintNumber(int a){
               Console.WriteLine(a);
          }

     }
     class Five{
          static void Main(String[] args){
               Action printText = new Action(MethodCollections.printName);
               Action<String> print = new Action<string>(MethodCollections.Print);
               Action<int> primeNumbers = new Action<int>(MethodCollections.PrintNumber);
               // Action<>

          }
     }
    
     
}