using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample002
{
    public partial class Form1 : Form
    {
        private List<MyRectange> _list;

        private void CreateList()
        {
            new MyRectange { Name = "D1", Width = 5, Height = 5 };
            new MyRectange { Name = "D2", Width = 10, Height = 10 };
            new MyRectange { Name = "D3", Width = 20, Height = 20 };
            new MyRectange { Name = "D4", Width = 100, Height = 100 };

        }
        private void SetCombobox()
        {
            comboBox1.DataSource=_list;
            comboBox1.DisplayMember="Name";
            comboBox1.ValueMember="Area";
        }

        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetCombobox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SelectedItem 還是MyRectangle
            int area = (int)comboBox1.SelectedValue;
            MessageBox.Show(area.ToString());
        }
    }
}
