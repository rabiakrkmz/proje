using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("NO", 50);
            listView1.Columns.Add("AD", 200);
            listView1.Columns.Add("SOYAD", 200);
            listView1.Width = 455;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ogrno, ad, soyad;
            ogrno = textBox1.Text;
            ad = textBox2.Text;
            soyad = textBox3.Text;
            string[] bilgiler = { ogrno, ad, soyad };

            ListViewItem kayit = new ListViewItem(bilgiler);

            listView1.Items.Add(kayit);
        }
    }
}
