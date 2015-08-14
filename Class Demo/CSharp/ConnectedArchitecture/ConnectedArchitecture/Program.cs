using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;


namespace ConnectedArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Where is the data?
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from Emp";
                //select ename from Emp where eid=101;
            cmd.Connection = con;

            //Reserve the channel
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            Console.WriteLine("Count=" + count);
            con.Close(); //Release the channel
        }
    }
}
