using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class Добавление_имени_и_телефона_фирмы : Form
    {
        DB db;
        List<string> Tel = new List<string>();
        List<string> Tel2 = new List<string>();
        public Добавление_имени_и_телефона_фирмы(DB db)
        {
            InitializeComponent();
            this.db = db;
            comboBox1.DataSource = db.zakashiks;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;
            comboBox2.DataSource = db.postavshiks;
            comboBox2.DisplayMember = "Name";
            comboBox2.SelectedIndex = 0;
        }
        void show() 
        {
            listView1.Items.Clear();
            if (comboBox1.SelectedItem == null)
                return;
            Zakashik name = (Zakashik)comboBox1.SelectedItem;
            foreach (var telefon  in name.Tel_Zakashiks)
            {
                ListViewItem type1 = new ListViewItem(telefon);
                type1.Tag = telefon;
                listView1.Items.Add(type1);
            }
        }
        void show2()
        {
            listView2.Items.Clear();
            if (comboBox2.SelectedItem == null)
                return;
            Postavshik name = (Postavshik)comboBox2.SelectedItem;
            foreach (var telefon in name.Tel_Postavshiks)
            {
                ListViewItem type1 = new ListViewItem(telefon);
                type1.Tag = telefon;
                listView2.Items.Add(type1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Save();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            Zakashik zakashik = (Zakashik)comboBox1.SelectedItem;
            zakashik.Tel_Zakashiks.Add(textBox2.Text);
            db.Save();
            show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
                return;
            Postavshik postavshik = (Postavshik)comboBox2.SelectedItem;
            postavshik.Tel_Postavshiks.Add(textBox3.Text);
            db.Save();
            show2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            show2();
        }
    }
}
