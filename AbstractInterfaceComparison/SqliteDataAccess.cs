using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    class SqliteDataAccess : DataAccess
    {
        // SqliteDataAccess is a derived class of the DataAccess base class

        // We can implement abstract methods in derived classes
        // with the override keyword
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }

    }
}
