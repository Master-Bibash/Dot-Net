// Example of interface 
//interface is a completely abstract class which can only contains abstract methods and properties (with empty bodies)

namespace Example{
     class ExampleThree{
          static void Main(String[] args){
               Pig myPig = new Pig();
               myPig.animalSound();
          }
     }
}


interface animanl{
     
     void animalSound(); //interface methods does not have a body
     void run();
}

class Pig:animanl{
     public void animalSound(){
          Console.WriteLine("Pig sayes :wee wee");
     }

    public void run()
    {
          Console.WriteLine("Pig can run");
    }
}