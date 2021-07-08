using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfo
{
    public class Store: IStore
    {
        public string Database { get; set; }
        public SqlConnection Connection { get; set; }

        public Store()
        {

        }
    }
}
