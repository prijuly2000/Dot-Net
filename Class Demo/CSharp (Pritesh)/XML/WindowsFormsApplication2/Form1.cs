using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication2
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
            doc.Load(@"D:\nt-pritz\MS.NET\MS FRAMEWORK\CLASS DEMO\WindowsFormsApplication2\WindowsFormsApplication2\XMLFile1.xml");
            MessageBox.Show(doc.NodeType.ToString());
            MessageBox.Show(doc.DocumentElement.Name);

            listBox1.Items.Add(doc.DocumentElement.Name);
            XmlElement cmp = doc.DocumentElement;
            XmlNodeList allEmp = cmp.ChildNodes;

            foreach (XmlNode emp in allEmp)
            {

                XmlNodeList allInfo = emp.ChildNodes;
                foreach (XmlNode info in allInfo)
                {
                    string str = info.Name;
                    str += " : ";
                    str += info.FirstChild.Value;
                    listBox1.Items.Add(str);
                }

                XmlAttributeCollection allAttr = emp.Attributes;
                foreach (XmlAttribute atr in allAttr)
                {
                    string str = atr.Name;
                    str += " : ";
                    str += atr.Value;
                    listBox1.Items.Add(str);
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\nt-pritz\MS.NET\MS FRAMEWORK\CLASS DEMO\WindowsFormsApplication2\WindowsFormsApplication2\XMLFile1.xml");
            XmlElement emp = doc.CreateElement("emp");
            XmlElement id = doc.CreateElement("id");
            XmlElement name = doc.CreateElement("name");
            XmlElement basic = doc.CreateElement("basic");

            id.InnerText = textBox1.Text;
            name.InnerText = textBox2.Text;
            basic.InnerText = textBox3.Text;
            emp.AppendChild(id);
            emp.AppendChild(name);
            emp.AppendChild(basic);
            emp.SetAttribute("designation",textBox4.Text);
            doc.DocumentElement.AppendChild(emp);
            XmlTextWriter tr = new XmlTextWriter(@"D:\nt-pritz\MS.NET\MS FRAMEWORK\CLASS DEMO\WindowsFormsApplication2\WindowsFormsApplication2\XMLFile1.xml",null);
            tr.Formatting=Formatting.Indented;

            doc.WriteContentTo(tr);
            tr.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlTextReader tr = new XmlTextReader(@"D:\nt-pritz\MS.NET\MS FRAMEWORK\CLASS DEMO\WindowsFormsApplication2\WindowsFormsApplication2\XMLFile1.xml");
            while (tr.Read())
            {
                if(tr.NodeType==XmlNodeType.Element)
                    listBox2.Items.Add(tr.Name);

                if (tr.NodeType == XmlNodeType.Text)
                    listBox2.Items.Add(tr.Value);
                
                if (tr.NodeType == XmlNodeType.Element)
                {
                    //listBox2.Items.Add(tr.Name);
                    if (tr.HasAttributes)
                    {
                        tr.MoveToFirstAttribute();
                        string str = tr.Name;
                        str += " : ";
                        str += tr.Value;
                        listBox2.Items.Add(str);
                    }
                    if (tr.MoveToNextAttribute())
                    {
                        string str = tr.Name;
                        str += " : ";
                        str += tr.Value;
                        listBox2.Items.Add(str);
                    }
                    if (tr.NodeType == XmlNodeType.Text)
                    {
                        listBox2.Items.Add(tr.Value);
                    }
                }
            }
        }

       
        
    }
}
