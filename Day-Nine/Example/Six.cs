namespace Example {

    
     class Six{
          public static event DelEventHandler add;
          public delegate void DelEventHandler();
           static void Nep(){
               Console.WriteLine("Nepal");
          }
          static void Us(){

               Console.WriteLine("US");
          }

          static void Main(String[] args){
               add+=new DelEventHandler(Nep);
               add += new DelEventHandler(Us);
               add();





          }
}

}

