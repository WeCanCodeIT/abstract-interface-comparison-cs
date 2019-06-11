using System;
using System.Collections.Generic; // This using statement allows access to the class library which houses the List class

namespace AbstractInterfaceComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a list of IDataAccess typed objects, which we filled
            // with instances of the SqlDataAccess and SqliteDataAccess classes.
            // They are implement the IDataAccess interface
            List<IDataAccess> databases = new List<IDataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            // This loop runs through the 3 methods we created, 
            // for both databases
            foreach (var db in databases)
            {
                db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
