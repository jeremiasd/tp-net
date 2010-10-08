using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Academia.Datos
{
    class General
    {
        public static SqlConnection getConexion()
        {
            SqlConnection conn = new SqlConnection(
            "Data Source=localhost;Initial Catalog=Academia_TP2;Integrated Security=true;");
            return conn;
        }
    }
}
