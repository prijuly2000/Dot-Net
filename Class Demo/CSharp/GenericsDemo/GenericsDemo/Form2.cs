using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
namespace GenericsDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string str = textBox1.Text;
            //IEnumerable<string> myData = str.Reverse<string>();
            //MessageBox.Show(myData.ToString());

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //It will store the data always in sorted order
            SortedDictionary<int, string> alldata = 
                new SortedDictionary<int, string>();
            alldata.Add(40, "Fourth");            
            alldata.Add(20, "Second");
            alldata.Add(10, "First");
            alldata.Add(30, "Third");
            

            foreach (int k in alldata.Keys)
            {
                string str = k.ToString() + 
                    " = " + alldata[k];
                listBox1.Items.Add(str);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HybridDictionary hd=new HybridDictionary(


        }

    }
}
