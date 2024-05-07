using System;

namespace Questions
{
     // Delegate declaration
     public delegate void MyDelegate(string msg);

     class Seventeen
     {
          public static void Main(String[] args)
          {
               Mathematics math = new Mathematics();
               // Subscribe to the log_event event by adding logging.createlog as a handler
               math.log_event += Logging.CreateLog; // Subscription-1

               // Call the sum method, which will trigger the log_event event
               math.Sum(5, 3);
           
              
          }
     }

     class Mathematics
     {
          // Event declaration using the MyDelegate delegate
          public event MyDelegate? log_event;

          public void Sum(int a, int b)
          {
               Console.WriteLine(a + b);
               // Trigger the log_event event
               if (log_event != null)
                    log_event("addition done"); // Event publishing
          }

          public void Diff(int a, int b)
          {
               Console.WriteLine(a - b);
               if (log_event != null)
                    log_event("mult done");
          }
     }

     class Logging
     {
          public static void CreateLog(String msg)
          {
               Console.WriteLine($"{msg}");
          }
     }
}
