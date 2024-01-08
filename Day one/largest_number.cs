using System;

class Largest{
     static void Main(string[] args){
          int[] a ={10,6,90,2,10,99,50};
          // Console.WriteLine(a[0]);
          int large = a[0];
          for(int i=0;i<a.Length;i++){
              if (a[i]>large){
                    large = a[i];
              }
              {
               
              }
          }
          Console.WriteLine("largest number is {0}", large);
          
     }
}