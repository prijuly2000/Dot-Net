using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace ConsoleConnectivity
{
    class Program
    {
        static void Main()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString="Data Source=comp48;Initial Catalog=database1;Integrated Security=True;Pooling=False";
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Emp ";
            cmd.Connection = con;
            con.Open();
            SqlDataReader count = cmd.ExecuteReader();
            
            while (count.Read())
            {
                Console.WriteLine(" id="+count[0]+"Name = " + count[1]+" basic="+count[2]);       
            }
            con.Close();
            Console.ReadLine();
        }
    }
}
