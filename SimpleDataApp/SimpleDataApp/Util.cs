using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Util - 1 More namespaces
using System.Configuration;

namespace SimpleDataApp{
    internal class Util{
        //Get the connection string form app congif file
        internal static string GetConnectionString() {
            //Util - 2 Assum Failure
            string returnValue = null;

            //Util - 3 Look for the name in the connectionStrings action
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[ "SimpleDataApp.Properties.Settings.connString"];
            //If found, return the connection string
            if (settings != null) 
                returnValue = settings.ConnectionString;

            return returnValue;
            
        }
    }
}
