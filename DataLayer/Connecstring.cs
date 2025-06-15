using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Connecstring
    {
        public Connecstring() {
        }
       public SqlDataAdapter SqlDataAdapter;
       public SqlCommand SqlCommand;
       public SqlConnection Connection;
       public String str_Connect= DataLayer.Properties.Settings.Default.QLNS_WINFORMConnectionString;
       

    }
}
