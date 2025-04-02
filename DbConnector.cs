using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoseliMart
{
    public class DbConnector
    {
        public static string ConnectionString
        {
            get
            {
                return GetConnectionString();
            }
        }

        private static string GetConnectionString()
        {
            // return "Server=.;Initial Catalog=KoseliMartDb;Integrated Security=True;";
            return "Server=.; Initial Catalog=KoseliMartDb;Integrated Security=True;" +
                " Encrypt=True; TrustServerCertificate=True;";
        }
    }
}
