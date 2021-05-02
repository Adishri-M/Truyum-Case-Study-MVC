using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    class ConnectionHandler
    {
        public static string GetConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            }
        }
    }
}
