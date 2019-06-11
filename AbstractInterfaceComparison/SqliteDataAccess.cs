using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    class SqliteDataAccess : DataAccess
    {
        // SqliteDataAccess is a derived class of the DataAccess base class
        // It inherits LoadConnectionString method from the DataAccess class

        // This virtual method can be overridden in the derived class
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        // This method is defined only in the derived class
        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }

    }
}
