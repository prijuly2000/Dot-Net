using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedDemo
{
    static class Variables
    {
        static public SqlConnection con;
        static public SqlCommand cmd;

        static public void CreateConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = @"";
            //remaining code ....
        }
    }
}
