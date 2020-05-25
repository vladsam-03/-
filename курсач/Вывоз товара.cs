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
    public partial class Вывоз_товара : Form
    {
        DB db;
        Towar towar;
        public Вывоз_товара(DB db, Towar tower)
        {
            InitializeComponent();
            this.db = db;
            towar = tower;
            comboBox1.DataSource = db.postavshiks;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            towar.Kolichestvo -= Convert.ToInt32(textBox1.Text);
            db.Save();
            Close();
        }
    }
}
