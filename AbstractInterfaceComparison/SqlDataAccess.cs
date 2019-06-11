using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    class SqlDataAccess : DataAccess
    {
        // SqlDataAccess inherits from the DataAccess abstract class
        // It is a blend of and Interface and a Base class

        // The method LoadConnectionString() is not abstract or virtual,
        // and therefore cannot be overridden in the derived class
        // It is implemented directly from the DataAccess class

        // When implementing an abstract method, 
        // the override keyword must be used
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
