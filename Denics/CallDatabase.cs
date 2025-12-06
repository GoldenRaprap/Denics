using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Denics
{
    internal class CallDatabase
    {
        String databaseStringName = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Amir\\Downloads\\Denics Project-20251204T130804Z-1-001\\Denics Project\\Denics_ Database\\Denics_db.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public CallDatabase() { }
        public String getDatabaseStringName()
        {
            return databaseStringName;
        }
    }
}
