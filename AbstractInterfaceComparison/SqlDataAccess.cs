using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    class SqlDataAccess : DataAccess
    {
        // SqlDataAccess is a derived class of the DataAccess base class

        // We can implement abstract methods in derived classes
        // with the override keyword
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQL Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");
        }

    }
}
