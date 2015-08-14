using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionDemo
{
    public partial class Form1 : Form
    {
        Assembly myAssembly;
        Type[] allTypes;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myAssembly = 
                Assembly.LoadFrom(@"D:\MS.Net\CSharp\OOPsConcept\OOPsConcept\bin\Debug\OOPsConcept.exe");
            MessageBox.Show(myAssembly.FullName);            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            allTypes= myAssembly.GetTypes();
            foreach (Type t in allTypes)
            {
                listBox1.Items.Add(t.FullName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Type t = allTypes[listBox1.SelectedIndex];
            ConstructorInfo []allCtor= t.GetConstructors();
            foreach (ConstructorInfo c in allCtor)
            {
                listBox2.Items.Add(c.Name);
                ParameterInfo []allPara = c.GetParameters();
                foreach (ParameterInfo p in allPara)
                {
                    listBox2.Items.Add(p.Name+" "+
                        p.ParameterType.ToString());
                    //p.ParameterType
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Type t = allTypes[listBox1.SelectedIndex];
            MemberInfo []allInfo= t.GetMembers();
            foreach (MemberInfo m in allInfo)
            {
                listBox3.Items.Add(m.Name);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Type t = allTypes[listBox1.SelectedIndex];
            //Object obj= Activator.CreateInstance(t); //default ctor
            //MessageBox.Show(obj.ToString());
            //Add the dll
            //First Parameter is name of assmebly and 2nd para is class
           //Object  obj = 
           //    Activator.CreateInstance(myAssembly.FullName,t.Name );
           // MessageBox.Show(obj.ToString());

           object obj =  
               Activator.CreateInstance(t, new object[] { 10, 20, 10 });
           MessageBox.Show(obj.ToString());


            

        }
    }
}
