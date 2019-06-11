using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    class SqlDataAccess : DataAccess
    {
        // SqlDataAccess is a derived class of the DataAccess base class
        // It inherits LoadConnectionString method from the DataAccess class

        // What if we don't override the virtual method?
        //public void LoadData(string sql)
        //{
        //    Console.WriteLine("Loading Microsoft SQL Data");
        //}

        // This method is defined only in the derived class
        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");
        }

    }
}
