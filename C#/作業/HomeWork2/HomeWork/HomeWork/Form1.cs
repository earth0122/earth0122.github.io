using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListBoxDateSource();
            ChangeDate();
        }
        private void CreateList()
        {
            _leftList = new List<string>
            {
                "農夫","狼","羊","菜"
            };
            _rightList = new List<string>();
        }
        private void SetListBoxDateSource()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }
        private void ChangeDate()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;
        }
        private void GetFail()
        {
            if (_rightList.Contains("農夫"))
            {
                if ((_leftList.Contains("狼") && _leftList.Contains("羊")) ||
                    (_leftList.Contains("菜") && _leftList.Contains("羊")))
                {
                    MessageBox.Show("失敗");
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
            }
            if (_leftList.Contains("農夫"))
            {
                if ((_rightList.Contains("狼") && _rightList.Contains("羊")) ||
                    (_rightList.Contains("菜") && _rightList.Contains("羊")))
                {
                    MessageBox.Show("失敗");
                    button1.Enabled = false;
                    button2.Enabled = false;
                }

            }

        }
        private void GetSuccess()
        {
            if (_rightList.Contains("狼") && _rightList.Contains("羊") && _rightList.Contains("菜") && _rightList.Contains("農夫"))
            {
                MessageBox.Show("成功");
                button1.Enabled = false;
                button2.Enabled = false;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string item = (string)listBox1.SelectedItem;
                _leftList.Remove(item);
                _rightList.Add(item);
                if (item != "農夫")
                {
                    _leftList.Remove("農夫");
                    _rightList.Add("農夫");
                }
                ChangeDate();
                button1.Enabled = false;
                button2.Enabled = true;
            }
            GetFail();
            GetSuccess();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string item = (string)listBox2.SelectedItem;
                _rightList.Remove(item);
                _leftList.Add(item);
                if (item != "農夫")
                {
                    _rightList.Remove("農夫");
                    _leftList.Add("農夫");
                }
                ChangeDate();
                button1.Enabled = true;
                button2.Enabled = false;
            }
            GetFail();
            GetSuccess();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateList();
            SetListBoxDateSource();
            ChangeDate();
            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
