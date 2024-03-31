using System.Collections.Generic;
namespace Example

{


    class Three
    {
        static void Main(string[] args)
        {
            //      List<Person> ListOFPerson = new List<Person>();
            //      Person sind=new Person();
            //      sind.PersonName = "bibash";
            //      sind.Age = "23";
            //      sind.Gender = "Male";
            //      sind.PersonArea = "sindhuli";
            //      ListOFPerson.Add(sind);
            //      GridView.
            //     var mydata=from pa on ListOFPerson where pa
            List<string> query = new List<string>(){
               "This is ",
               "Welcome to",
               "the boy is ",
               "bibash is master"
          };
            var r = from L in query where L.Contains("bibash") select L;
            foreach (String i in r)
            {
                Console.WriteLine($"the data is  {i}");

            }




        }
    }
    public class Person
    {

        private String _name;
        private String _age;
        private String _gender;
        private String _area;

        public string PersonName
        {
            get { return _name; }
            set { _name = value; }
        }
        public string PersonArea
        {
            get { return _area; }
            set { _area = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }


    }
}




