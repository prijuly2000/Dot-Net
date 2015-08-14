using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingLogin_ok
{
    public partial class Form4 : Form
    {
        Form3 f3;
        public Form4(Form3 f3)
        {
            InitializeComponent();
            timer1.Start();
            this.f3 = f3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Maximum == progressBar1.Value)
            {
                timer1.Stop();
                MessageBox.Show("Congrats!!! You have got " + f3.total + " marks");
                Application.Exit();

            }
            
        }

      
    }
}
