using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    // This is an interface
    public interface IDataAccess
    {
        // Methods in an interface have no body.  
        // There is no implementation in the Interface 
        string LoadConnectionString(string name);
        void LoadData(string sql);
        void SaveData(string sql);
    }
}
