using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;

namespace PeopleReader
{
    //class Person
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public int? Age { get; set; }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            CoreVoorKerelsMetHarenOpDeTanden();
           // PatatGeneratie();


        }

        private static void PatatGeneratie()
        {
            
        }

        private static void CoreVoorKerelsMetHarenOpDeTanden()
        {
            string iname = "Henk', 42);DROP table dbo.Person;--";
            string conStr = @"Server=.\sqlexpress;Database=SimpleDB;Trusted_Connection=True;";
            var connection = new SqlConnection(conStr);
            connection.Open();
            var insert = new SqlCommand();
            insert.Connection = connection;
            insert.CommandText = "INSERT INTO dbo.Person (Name, Age) VALUES ('" + iname + "', 42)";
            //insert.Parameters.AddWithValue("@name", iname);
            insert.ExecuteNonQuery();

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM dbo.Person";

            var dataReader = command.ExecuteReader(System.Data.CommandBehavior.SequentialAccess);
            while (dataReader.Read())
            {
                int id = (int)dataReader[0];
                string name = (string)dataReader[1];
                int? age = null;
                var elem = dataReader[2];
                if (elem.GetType() != typeof(DBNull))
                {
                    age = (int?)elem;
                }
                Console.WriteLine($"[{id}] {name}  ({age ?? -1})");
            }


            connection.Close();
        }
    }
}
