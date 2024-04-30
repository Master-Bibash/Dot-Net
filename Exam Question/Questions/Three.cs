// Write a C# program to show insert and select operation in database. [5]

using System;
using System.Data.SQLite;

namespace Questions
{
     class Three{
          static void Main(string[] args)
          {
               string connectionString = @"Data Source=mydatabase.db;Version=3;";

               // Create a new SQLite database connection
               using (var connection = new SQLiteConnection(connectionString))
               {
                    // Open the connection
                    connection.Open();

                    // Create a table if it doesn't exist
                    string createTableQuery = "CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY, Name TEXT)";
                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                         command.ExecuteNonQuery();
                    }

                    // Insert a new record into the table
                    string insertQuery = "INSERT INTO MyTable (Name) VALUES (@name)";
                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                         command.Parameters.AddWithValue("@name", "John Doe");
                         command.ExecuteNonQuery();
                    }

                    // Select all records from the table
                    string selectQuery = "SELECT * FROM MyTable";
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                         using (var reader = command.ExecuteReader())
                         {
                              Console.WriteLine("Records in MyTable:");
                              while (reader.Read())
                              {
                                   int id = reader.GetInt32(0);
                                   string name = reader.GetString(1);
                                   Console.WriteLine($"Id: {id}, Name: {name}");
                              }
                         }
                    }
               }
          }
     }
}
