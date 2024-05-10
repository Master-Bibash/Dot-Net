using System;

namespace Questions
{
     // Delegate declaration
    

     class Twenty
     {
          public static void Main(String[] args)
          {
               //Example of garbage collection
               for (int i = 0; i < 4; i++)
               {
                    Console.WriteLine(i);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Console.WriteLine(i);
                    
               }


          }
           ~Twenty()
          {
               Console.WriteLine("its a garbage");
          }
     }
    


    
}
