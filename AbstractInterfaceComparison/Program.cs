using System;
using System.Collections.Generic; // This using statement allows access to the class library which houses the List class

namespace AbstractInterfaceComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // We could instantiate any of the following objects
            // da only has a LoadConnectionString() method
            DataAccess da = new DataAccess();

            // da_sqlite and dq_sql have access to the LoadConnectionString() 
            // method, in addition to LoadData() and SaveData() methods
            SqliteDataAccess da_sqlite = new SqliteDataAccess();
            SqlDataAccess da_sql = new SqlDataAccess();

            // This is a list of DataAccess typed objects, which we filled
            // with instances of the SqlDataAccess and SqliteDataAccess classes.
            // They are derived classes of the DataAccess base class
            List<DataAccess> databases = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                // Why doesn't the following method run?
                // db.SaveData("insert into table");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
