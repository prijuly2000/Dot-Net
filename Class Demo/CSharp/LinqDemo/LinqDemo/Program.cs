using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;

namespace LinqDemo
{
    class Program
    {
        static void MainObject(string[] args)
        {
            //LinQ on Objects
            List<int> allNums = new List<int>();
            allNums.Add(10);
            allNums.Add(1);
            allNums.Add(100);
            allNums.Add(56);
            allNums.Add(90);
            allNums.Add(14);

            var selected= from x in allNums
                          where x>10 && (x%20==0)
                select x;

            foreach (var x in selected)
            {
                Console.WriteLine(x);
            }
        }

        static void MainXMl(string[] args)
        {
            XElement doc = 
                XElement.Load(@"D:\MS.Net\CSharp\LinqDemo\LinqDemo\Emp.xml");
            IEnumerable <XElement> allNodes = doc.Descendants();

            var selected = from x in allNodes
                           where (x.Name == "Basic") &&
                           (int.Parse(x.Value) > 10000)
                           select x;
            foreach (var x in selected)
            {
                Console.WriteLine(x.Name+x.Value);
            }
        }
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("Select * from Emp", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            IEnumerable<DataRow> allRows =
                ds.Tables[0].AsEnumerable();

            var selected = from x in allRows
                           where (double)x[2] >10000
                         select x;


            foreach (var x in selected)
            {
                Console.WriteLine(x[0].ToString() +
                    " " + x[1].ToString());
            }

        }
    }
}
