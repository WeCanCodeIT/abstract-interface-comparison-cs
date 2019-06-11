using System;
using System.Collections.Generic; // This using statement allows access to the class library which houses the List class

namespace AbstractInterfaceComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a list of DataAccess typed objects, which we filled
            // with instances of the SqlDataAccess and SqliteDataAccess classes.
            // They are derived from the DataAccess abstract class
            List<DataAccess> databases = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            // If we wanted, we could instantiate instances of the derived classes
            DataAccess da_sqlite = new SqliteDataAccess();
            DataAccess da_sql = new SqlDataAccess();

            // ...but not the abstract base class
            // DataAccess da = new DataAccess();

            foreach (var db in databases)
            {
                // Defined in the DataAccess abstract base class
                db.LoadConnectionString("demo");

                // Both methods below have their own implemention in the
                // SqlDataAccess and SqliteDataAccess derived classes
                db.LoadData("select * from table"); 
                db.SaveData("insert into table");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
