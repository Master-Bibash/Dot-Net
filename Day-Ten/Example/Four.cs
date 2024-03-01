//exceptoin handling try catch example

namespace Example
{
     class Four{
          static void Main(String[] args){
               // int b=10;
               try{

                    int[] a = { 1, 2, 3 };
                    Console.WriteLine(a[6]);
                    // int m= b / 0;
                    // Console.WriteLine($"div anser is{m} ");

               }
               catch(Exception e){
                    Console.WriteLine($"error is {e}");

               }finally{
                    Console.WriteLine("The program has ended");
               }
          }
     }
     
}