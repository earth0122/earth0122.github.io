using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample003
{
    public partial class Form1 : Form
    {
        private List<MyRectangle> _list;



        private void CreateList()
        {
            _list = new List<MyRectangle>()
            {
                new MyRectangle { Name = "D1", Width = 5, Height = 5 },
                new MyRectangle { Name = "D2", Width = 10, Height = 10 },
                new MyRectangle { Name = "D3", Width = 20, Height = 20 },
                new MyRectangle { Name = "D4", Width = 100, Height = 100 }
            };
        }

        class MyRectangle
        {
            public string Name { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Area
            {
                get
                {
                    return Width * Height;
                }
            }
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
            comboBox1.ValueMember = "area";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox theComboBox = (ComboBox)sender;
            int index = theComboBox.SelectedIndex;
            MyRectangle item = _list[index];
            MessageBox.Show($"取得索引 {index} 的面積為: {item.Area}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
