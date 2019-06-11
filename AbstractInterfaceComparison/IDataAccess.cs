using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceComparison
{
    // This is an interface, notice the keyword "interface" in place of "class"
    // Naming convention for interfaces is "I" followed by Pascal case
    public interface IDataAccess
    {
        // Methods in an interface have no body.  
        // There is no implementation in the Interface 
        string LoadConnectionString(string name);
        void LoadData(string sql);
        void SaveData(string sql);
    }
}
