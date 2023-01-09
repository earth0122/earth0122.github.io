using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample005
{
    public partial class Form1 : Form
    {
        private List<string> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
        }
        private void CreateList()
        {
            _list = new List<string>()
            {
                "Dog","Cat","Monkey","Fly","Donkey","Dog2"
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = _list.Find((x) => x == textBox1.Text);
            MessageBox.Show($"Find:{result}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = _list.FindIndex((x) => x == textBox1.Text);
            MessageBox.Show($"Find Index:{index}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> results = _list.FindAll((x) => x.Contains(textBox1.Text));
            //string result = string.Empty;
            //foreach (string item in results)
            //{
            //    result = result + item + ",";
            //}
            //MessageBox.Show($"Find All:{result}");
            MessageBox.Show(string.Join(",", results));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string result = _list.FindLast((x)=>x.Contains(textBox1.Text));
            MessageBox.Show($"Find Last:{result}");
        }
    }
}
