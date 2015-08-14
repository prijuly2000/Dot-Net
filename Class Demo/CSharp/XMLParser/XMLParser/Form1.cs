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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            //To create the XML DOM Tree
            doc.Load(@"D:\MS.Net\CSharp\XMLParser\XMLParser\Emp.xml");
            MessageBox.Show(doc.NodeType.ToString());
            listBox1.Items.Add(doc.DocumentElement.Name);
            XmlElement cmp = doc.DocumentElement;

            XmlNodeList allEmp = cmp.ChildNodes;
           // MessageBox.Show(allEmp.Count.ToString());
            foreach (XmlNode emp in allEmp)
            {
                XmlNodeList allInfo = emp.ChildNodes;
                foreach (XmlNode info in allInfo)
                {
                    string str = info.Name;
                    str += " = ";
                    str += info.FirstChild.Value;
                    listBox1.Items.Add(str);
                }
                /////////////////Fetching the attributes
                 XmlAttributeCollection allAttr = emp.Attributes;
                 foreach (XmlAttribute atr in allAttr)
                 {
                     string str = atr.Name;
                     str += " = ";
                     str += atr.Value;
                     listBox1.Items.Add(str);
                 }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            //To create the XML DOM Tree
            doc.Load(@"D:\MS.Net\CSharp\XMLParser\XMLParser\Emp.xml");

            XmlElement emp = doc.CreateElement("Emp");
            XmlElement eid = doc.CreateElement("EId");
            XmlElement enm = doc.CreateElement("EName");
            XmlElement bs = doc.CreateElement("Basic");
            eid.InnerText = textBox1.Text;
            enm.InnerText = textBox2.Text;
            bs.InnerText = textBox3.Text;
            emp.AppendChild(eid);
            emp.AppendChild(enm);
            emp.AppendChild(bs);
            emp.SetAttribute("Department", textBox4.Text);
            emp.SetAttribute("Designation", textBox5.Text);
            doc.DocumentElement.AppendChild(emp);
            //Writing to file
            XmlTextWriter tr = 
                new XmlTextWriter(@"D:\MS.Net\CSharp\XMLParser\XMLParser\Emp.xml", null);
            tr.Formatting = Formatting.Indented;
            doc.WriteContentTo(tr);
            tr.Close();//save the changes

        }
    }
}
