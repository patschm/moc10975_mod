using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace PeopleReader
{


    class Program
    {
        static void Main(string[] args)
        {
            //CoreVoorKerelsMetHarenOpDeTanden();
           PatatGeneratie();
        }

        private static void PatatGeneratie()
        {
            string conStr = @"Server=.\sqlexpress;Database=SimpleDB;Trusted_Connection=True;";

            DbContextOptionsBuilder bld = new DbContextOptionsBuilder();  
            //ctx.Database.EnsureCreated();
            bld.UseSqlServer(conStr);
            MijnContext ctx = new MijnContext(bld.Options);
            List<Person> peeps = ctx.People.Where(p => p.Age > 30).ToList();
            foreach(Person p in peeps)
            {
                Console.WriteLine($"[{p.ID}]{p.Name} ({p.Age})");
            }
          
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
//            insert.CommandText = "INSERT INTO dbo.Person (Name, Age) VALUES (@name, 42)";
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
