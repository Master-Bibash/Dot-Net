using System;
namespace DaySix.Example
{

     class VSNI
     {
          static void Main(string[] args)
          {
               VSi vsObject = new VSi();
               bool continueExecution = true;

               do
               {
                    Console.WriteLine("Enter\n 1 to admit. \n 2 to add faculty. \n 3 to restrict.");

                    //so here int.parse is a method that tries to parse a string as an integer.The out int userOPtion  part means if parsing is successfull the parsed interger will be stored in userOPtion if fails tryparse will return false and userOPtion will have default value if 0
                    if (int.TryParse(Console.ReadLine(), out int userOPtion))
                    {
                         switch (userOPtion)
                         {
                              case 1:
                                   vsObject.Admission();
                                   break;
                              case 2:
                                   vsObject.AddFaculty();
                                   break;
                              case 3:
                                   vsObject.Restrict();
                                   break;
                              default:
                                   Console.WriteLine("Please select option 1, 2, or 3.");
                                   break;
                         }
                    }
                    else
                    {
                         Console.WriteLine("Invalid input. Please enter a valid number.");

                    }
                    Console.WriteLine("Do you want to perform another action? (y/n)");
                    string continueOption = Console.ReadLine().ToLower();
                    if (continueOption != "y")
                    {
                         continueExecution = false;
                    }




               } while (continueExecution);
          }
     }
}



class VSi
{
     private string[] faculty = new string[3];
     private int studentNum;

     public int StudentNum
     {
          get { return studentNum; }
          //Inn this specific case, when you write private set { studentNum = value; }, it means that the private property studentNum can only be modified within the class, and the new value assigned to it is the value provided by the set operation, which is represented by the value keyword.
          //so new value will be stored in studentNum which is value
          private set { studentNum = value; }
     }
     public string[] Faculty
     {
          get
          {
               return faculty;
          }
          private set
          {
               faculty = value;
          }
     }

     public void Admission()
     {
          Console.WriteLine("Enter student number to admit: ");
          if (int.TryParse(Console.ReadLine(), out int part1))
          {
               StudentNum += part1;
               Console.WriteLine("Number of students admitted: " + StudentNum);
          }
          else
          {
               Console.WriteLine("Invalid input. Please enter a valid number.");
          }
     }

     public void Restrict()
     {
          if (StudentNum > 0)
          {
               Console.WriteLine("Enter number to restrict: ");
               if (int.TryParse(Console.ReadLine(), out int num))
               {
                    if (studentNum >= num)
                    {
                         StudentNum -= num;
                         Console.WriteLine("Total number of students is now: " + StudentNum);
                    }
                    else
                    {
                         Console.WriteLine("value cannot be grater than student");
                    }
               }
               else
               {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
               }
          }
     }

     public void AddFaculty()
     {
          for (int i = 0; i < Faculty.Length; i++)
          {
               Console.WriteLine($"Enter faculty member {i + 1}");
               Faculty[i] = Console.ReadLine();

          }
          foreach (var facultymember in Faculty)
          {
               Console.WriteLine("faculty are " + facultymember);

          }
     }
}
