using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    public abstract class DataAccess
    {
        // This is an abstract class.  It will not allow an object
        // to be directly instantiated from it.  Objects can be
        // instantiated from any of its derived classes.

        // Below is a method of the abstract class.  It is not
        // abstract or virtual.  Therefore, it can not be overridden
        // in the derived classes.
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        // Below are abstract methods.  They do not have a code body, and
        // therefore they do not have any direct implementation in this class.
        // To implement these methods you must override them
        // in a derived class

        // LoadData() and SaveData() will look different for Sql vs. Sqlite
        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);

    }
}
