using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace TextFileSamples003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var list = CreateData();
            dataGridView1.DataSource = list;
        }
        private List<Restaurant> CreateData()
        {
            string fileName = "A53000000A-000003-003.csv";
            if (File.Exists(fileName))
            {
                return File.ReadLines(fileName).Skip(1)
                                               .Select(x=>x.Split(','))
                                               .Select(x=>new Restaurant
                                               { 
                                                 Seq = int.Parse(x[0]),
                                                 DishName = x[1],
                                                 Shop=x[3],
                                                 Address = x[4],
                                                 Tel = x[5],
                                               }).ToList();
            }
            return null;
        }
       
    }
    class Restaurant
    {
        public int Seq { get; set; }
        public string DishName { get; set; }
        public string Shop { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

    }
}
