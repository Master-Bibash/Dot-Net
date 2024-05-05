using System;
namespace Questions

{
     //property example
     public class human
     {
          private string name;
          public string Name{
               //getter
               get { return name; }
               set{ name = value; }
          }
         

     }
     //indexers
     class phone{
          private string[] names = new string[10];

          public string this[int i]{
               get{
                    return names[i];
               }
               set{
                    names[i] = value;
               }

          }



     }
     class Six
     {
          public static void Main(string[] args)
          {
               human h=new human();
               h.Name = "bibash";
               Console.WriteLine(h.Name);

               phone p=new phone();
               p[0] = "Bibash";
               Console.WriteLine(p[0]);
               





          }


     }



}
