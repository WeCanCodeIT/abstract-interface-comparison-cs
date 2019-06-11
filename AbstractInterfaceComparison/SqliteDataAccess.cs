using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    class SqliteDataAccess : IDataAccess
    {
        // SqliteDataAccess implements the IDataAccess interface

        // When implementing a method from an interface, the
        // override keyword is not needed
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        public void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }

    }
}
