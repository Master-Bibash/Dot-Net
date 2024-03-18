using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Example
{
     class UserCrud
     {
          MySqlConnection conn;
          MySqlCommand command;

          public void CreateConnection()
          {
               string constr = "Server=localhost;Database=home;Uid=root;Pwd=password;";

               conn = new MySqlConnection(constr);
               conn.Open();
          }

          public void InsertUpdateDelete(string sql)
          {
               command = new MySqlCommand(sql, conn);
               command.ExecuteNonQuery();
               Console.WriteLine("User operation successful");
          }

          public void SelectRecords(string sql)
          {
               command = new MySqlCommand(sql, conn);
               MySqlDataAdapter adapter = new MySqlDataAdapter(command);
               DataTable dt = new DataTable();
               adapter.Fill(dt);

               if (dt.Rows.Count != 0)
               {
                    Console.WriteLine("Sid\t User Name\t Fullname\t Address\t email");

                    foreach (DataRow row in dt.Rows)
                    {
                         string sid = row["id"].ToString();
                         string user_name = row["user_name"].ToString();
                         string full_name = row["full_name"].ToString();
                         string address = row["address"].ToString();
                         string email = row["email"].ToString();
                         Console.WriteLine($"{sid}\t {user_name}\t {full_name}\t {address}\t {email}");
                    }
               }
               else
               {
                    Console.WriteLine("No records found.");
               }
          }
     }

     class One
     {
          static void Main(string[] args)
          {
               UserCrud crud = new UserCrud();
               int id = 0;

               try
               {
                    crud.CreateConnection();

               x: Console.WriteLine("1> Insert\t 2> Update\t 3> Delete\t 4> Select");
                    Console.WriteLine("Enter choice:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    string sql = "", uname = "", fname = "", address = "", email = "";

                    switch (n)
                    {
                         case 1:
                              Console.WriteLine("Enter username:");
                              uname = Console.ReadLine();
                              Console.WriteLine("Enter full name:");
                              fname = Console.ReadLine();
                              Console.WriteLine("Enter address:");
                              address = Console.ReadLine();
                              Console.WriteLine("Enter email:");
                              email = Console.ReadLine();
                              sql = $"INSERT INTO Person(user_name, full_name, address, email) VALUES('{uname}', '{fname}', '{address}', '{email}')";
                              crud.InsertUpdateDelete(sql);
                              break;
                         case 2:
                              Console.WriteLine("Enter id to update:");
                              id = Convert.ToInt32(Console.ReadLine());
                              Console.WriteLine("Enter username:");
                              uname = Console.ReadLine();
                              Console.WriteLine("Enter full name:");
                              fname = Console.ReadLine();
                              Console.WriteLine("Enter address:");
                              address = Console.ReadLine();
                              Console.WriteLine("Enter email:");
                              email = Console.ReadLine();
                              sql = $"UPDATE Person SET user_name = '{uname}', full_name = '{fname}', address = '{address}', email = '{email}' WHERE id = {id}";
                              crud.InsertUpdateDelete(sql);
                              break;
                         case 3:
                              Console.WriteLine("Enter id to delete:");
                              id = Convert.ToInt32(Console.ReadLine());
                              sql = $"DELETE FROM Person WHERE id = {id}";
                              crud.InsertUpdateDelete(sql);
                              break;
                         case 4:
                              Console.WriteLine("enter id to get data");
                              int getdata = Convert.ToInt32(Console.ReadLine());

                              sql = $"SELECT * FROM Person where id={getdata} ";
                              crud.SelectRecords(sql);
                              break;
                         default:
                              Console.WriteLine("Incorrect choice");
                              break;
                    }
                    goto x;
               }
               catch (Exception ex)
               {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Connection failed.");
               }
               Console.ReadKey();
          }
     }
}
