//make a class vs as main
//makea faculty array of string and int student number
//make methods admission,resticate and add faculty they are public

using System;
namespace DaySix.Example
{

     class VSN
     {
          static void Main(string[] args)
          {
               VS vsobject = new VS();
               vsobject.admission();
               vsobject.AddFaculty("MAth");
               vsobject.Restrict(1);
          }
     }
     class VS
     {
          private string[] studnetfacuty;
          private int studentNum;
          public VS()
          {
               studnetfacuty = new string[3];
               studentNum = 0;

          }


          //method for admission
          public void admission()
          {
               Console.WriteLine("student is admitted");
               studentNum++;
          }
          //method for resticating
          public void Restrict(int studentNum)
          {
               if (studentNum > 0)
               {
                    for (int i = 0; i < studnetfacuty.Length; i++)
                    {
                         if (studnetfacuty[i] != null && i + 1 == studentNum)
                         {
                              Console.WriteLine($"Student with number {studentNum} restricted. Faculty removed: {studnetfacuty[i]}");
                              studnetfacuty[i] = null;
                              studentNum--;
                              return;


                         }
                    }
                    Console.WriteLine($"No student found with number {studentNum}.");

               }
               else
               {
                    Console.WriteLine("No students to restrict.");

               }
          }

          //method for adding faculty
          public void AddFaculty(string facultyName)
          {
               for (int i = 0; i < studnetfacuty.Length; i++)
               {
                    if (studnetfacuty[i] == null)
                    {
                         studnetfacuty[i] = facultyName;
                         Console.WriteLine("Faculty added: " + facultyName);
                         return;
                    }
               }
               Console.WriteLine("Maximum faculty limit reached.");

          }



     }
}