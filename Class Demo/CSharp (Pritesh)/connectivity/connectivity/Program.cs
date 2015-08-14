using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace connectivity
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=COMP48;Initial Catalog=neeraj;Integrated Security=True;Pooling=False";
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Emp";
            cmd.Connection = con;
            con.Open();
            SqlDataReader  count =cmd.ExecuteReader();
            while (count.Read())
            {
                Console.WriteLine("id = " + count[0]+"name="+count[1]+"basic="+count[2] );
            }
            con.Close();
            Console.ReadLine();

        }
    }
}
