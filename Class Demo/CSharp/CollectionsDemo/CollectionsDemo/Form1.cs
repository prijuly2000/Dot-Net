using System;

using System.Collections;

using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CollectionsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stack st = new Stack();
            st.Push(10);
            st.Push("Hello");
            st.Push(23.33);
            foreach (object obj in st)
            {
                listBox1.Items.Add(obj);
            }
            MessageBox.Show(st.Pop().ToString());
            MessageBox.Show(st.Peek().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Queue qt = new Queue();
            qt.Enqueue(10); //Push
            qt.Enqueue("Hello");
            qt.Enqueue(30.20);
            foreach (object obj in qt)
            {
                listBox2.Items.Add(obj.ToString());
            }
            MessageBox.Show(qt.Dequeue().ToString()); //Pop

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add(20); //To add a new element at the end of collection
            arr.Add(30);
            arr.Add(40);
            arr.Add(50);
            arr.Add(60);
            arr.Add(70);
            arr.Add(80);
            arr.Add(90);
            arr[3] = 400; //To overwrite the value
            MessageBox.Show(arr.Capacity.ToString());
            arr.Insert(3, 1000);//insert in the middle
            //shift the other elements =>index,value
            foreach (object obj in arr)
            {
                listBox3.Items.Add(obj.ToString());
            }

            arr[12] = 10; //Runtime error

            arr.Remove(10);  //remove 10 <=value
            arr.RemoveAt(1); //remove element at index 1 <=index
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stack<int> st = new Stack<int>();
            Queue<int> qt = new Queue<int>();
            List<int> arr = new List<int>(); //ArrayList
            //Hash Table => Dictionary
            Dictionary<int, string> table = 
                new Dictionary<int, string>();
            table.Add(10, "First");
            table.Add(20, "Second");
            table.Add(30, "Third");
            table.Add(40, "Fourth");

            MessageBox.Show(table[10]);

            foreach (int k in table.Keys)
            {
                listBox4.Items.Add(k.ToString());
            }
            foreach (string value in table.Values)
            {
                listBox4.Items.Add(value);
            }

        }
    }
}
