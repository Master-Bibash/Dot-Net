
using System;

namespace Example
{
     class ExampleOne 
     {
          static void Main(string[] args)
          {
               Name name1;
               Name name2;

               //num of one person
               name1.x = 1;
               name1.y = 2;
               Console.WriteLine(name1.x);
               Console.WriteLine(name1.y);
               //num of twi person
               name2.y = 3;
               name2.x = 4;
               Console.WriteLine(name2.x);
               Console.WriteLine(name2.y);



          }



     }
     struct Name
     {


          public int x;
          public int y;
     }


}



