using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutSample001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = textBox1.Text;
            int result;
            bool isParsed = int.TryParse(source, out result);
            string message;
            if (isParsed)
            {
                message = $"正確解析字串{source}為整數{result}";
            }
            else
            {
                message = $"無法解析字串{source}，只好傳回預設值{result}";
            }
            MessageBox.Show(message);
        }
    }
}
