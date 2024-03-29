using System;
class interfaceexample{

     //interface object cannot be made
     interface isAnimal{
          void animalSound();
     }
     class Cow:isAnimal{
          public void animalSound(){
               Console.WriteLine("the cow says wee wee");
          }
     }
     static void Main(string[] args){
          Cow cow = new Cow();
          cow.animalSound();


               
     }

}