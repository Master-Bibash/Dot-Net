using System;
namespace Questions

{
    public class person
    {
        private string name;
        public void setname(string name)
        {
            this.name = name;
        }

        public string getname() => this.name;

    }
    class Five
    {
        public static void Main(string[] args)
        {
            person p = new person();
            p.setname("bibash");
            Console.WriteLine(p.getname());





        }


    }



}
