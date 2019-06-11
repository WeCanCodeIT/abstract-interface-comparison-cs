using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    public class DataAccess
    {
        // This is a base class.  Objects can be
        // instantiated from it or any of its derived classes.

        // Below is a method of the base class.  
        // It is inherited by the derived classes.
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        // Below is a virtual method of the base class.
        // It can be overridden by the derived class.
        public virtual void LoadData(string sql)
        {
            Console.WriteLine("Loading Data");
        }


    }
}
