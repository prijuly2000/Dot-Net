using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterformCommunication
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2()
        {
            InitializeComponent();
        }

       


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bye bye...");
            //To terminate the application
            Application.Exit();
        }
    }
}
