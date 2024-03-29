namespace Example
{


     class One
     {
          public delegate void del1(String part1);
               
          static void Main(String[] args)
          {
               del1 vs1 = delegate (String name)
               {
                    Console.WriteLine($"name is {name}");
               };
               vs1("Bibash");


          }
     }
}