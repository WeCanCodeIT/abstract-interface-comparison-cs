using System;
using System.Collections.Generic; // This using statement allows access to the class library which houses the List class

namespace AbstractInterfaceComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Why doesn't the following code run?
            // DataAccess da = new DataAccess();

            // Why does the following code run?  What does it do?
            DataAccess da = new SqlDataAccess();

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
                db.SaveData("insert into table");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
