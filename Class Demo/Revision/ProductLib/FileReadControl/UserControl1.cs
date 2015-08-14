using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileReadControl
{
    public partial class MySearch : UserControl
    {
        public event EventHandler fileDemo;
        public event EventHandler fileError;

        public MySearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {

                FileInfo info =
                    new FileInfo(op.FileName);
                if (info.Length >= 100)
                {
                    fileDemo(sender, e);
                }
                else
                {
                    fileError(sender, e);
                }
            }

        }
    }
}
