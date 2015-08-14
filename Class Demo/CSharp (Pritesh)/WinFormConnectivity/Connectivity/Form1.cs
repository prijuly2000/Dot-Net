using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace Connectivity
{
    public partial class Form1 : Form
    {
        int i=0;
        int x = 20; int y = 20;
        int r=100, g=10, b=10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=comp48;Initial Catalog=database1;Integrated Security=True;Pooling=False";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from emp";
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr ;
            dr=cmd.ExecuteReader();
            textBox1.Clear();
            TextBox[] t = new TextBox[15];
            while (dr.Read())
            {
                Thread.Sleep(500);

                r += 20;
                g += 30;
                b += 40;
                    t[i] = new TextBox();
                    this.Controls.Add(t[i]);
                    t[i].Location = new Point(x, y);
                    t[i].Text = dr[0].ToString() ;
                    t[i].BackColor = Color.FromArgb(r,g,b);
                   
                    this.Update();
                    x += 105;
                    i++;
                    t[i] = new TextBox();
                    this.Controls.Add(t[i]);
                    t[i].Location = new Point(x, y);
                    t[i].Text = dr[1].ToString();
                    t[i].BackColor = Color.FromArgb(r, g, b);
                    this.Update();
                    x += 105;
                    i++;
                    t[i] = new TextBox();
                    this.Controls.Add(t[i]);
                    t[i].Location = new Point(x, y);
                    t[i].Text = dr[2].ToString();
                    t[i].BackColor = Color.FromArgb(r, g, b);
                    this.Update();
                    
                    i++;
                    y += 21;
                    x = 20;
                    
                //textBox1.Text = dr[0].ToString();
                //textBox1.Update();
                //textBox2.Text = dr[1].ToString();
                //textBox2.Update();
                //textBox3.Text = dr[2].ToString();
                //textBox3.Update();

            }

           

            
        }
    }
}
