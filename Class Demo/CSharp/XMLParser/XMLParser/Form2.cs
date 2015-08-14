using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
namespace XMLParser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader tr = 
                new XmlTextReader(@"D:\MS.Net\CSharp\XMLParser\XMLParser\Emp.xml");
            while (tr.Read())
            {
                //Check if it is a start tag
                if (tr.NodeType == XmlNodeType.Element)
                {
                    listBox1.Items.Add(tr.Name);
                    if (tr.HasAttributes)
                    {
                        tr.MoveToFirstAttribute();
                        string str = tr.Name;
                        str += " = ";
                        str += tr.Value;
                        listBox1.Items.Add(str);
                    }
                    if (tr.MoveToNextAttribute())
                    {
                        
                        string str = tr.Name;
                        str += " = ";
                        str += tr.Value;
                        listBox1.Items.Add(str);
                    }
                }
                if (tr.NodeType == XmlNodeType.Text)
                {
                    listBox1.Items.Add(tr.Value);
                }
                
            }
        }
    }
}
