using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample001
{
    public partial class Form1 : Form
    {
        private List<MyRectangle> _list;
        private void CreateList()
        {
            _list = new List<MyRectangle>();
            _list.Add(new MyRectangle { Name = "D1", Width = 5, Height = 5 });
            _list.Add(new MyRectangle { Name = "D2", Width = 10, Height = 10 });
            _list.Add(new MyRectangle { Name = "D3", Width = 20, Height = 20 });
            _list.Add(new MyRectangle { Name = "D4", Width = 100, Height = 100 });
        }

        public Form1()
        {
            InitializeComponent();
            CreateList();           
            SetCombobox();
        }

        private void SetCombobox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Name";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyRectangle item = (MyRectangle)comboBox1.SelectedItem;
            MessageBox.Show($"{item.Name}的面積為:{item.GetArea()}");
        }
    }
}
