using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    class SqlDataAccess : IDataAccess
    {
        // SqlDataAccess implements the IDataAccess interface

        // When implementing a method from an interface, the
        // override keyword is not needed
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        public void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQL Data");
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");
        }

    }
}
