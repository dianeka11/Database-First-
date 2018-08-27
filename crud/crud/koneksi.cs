using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace crud
{
    class koneksi
    {

        public System.Data.SqlClient.SqlConnection GetConn()
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source= DESKTOP-PREHHMI\\SQLEXPRESS; Initial Catalog= akademik; Integrated Security=True";

            return conn;

        }
    }
}