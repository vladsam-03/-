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
    public partial class Товар : Form
    {
        DB db;
        public Товар(DB db)
        {
            InitializeComponent();
            this.db = db;
            comboBox1.DataSource = db.list;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            Towar towar = new Towar();
            towar.Name = textBox7.Text;
            towar.Type = (Type)comboBox1.SelectedItem;
            db.towars.Add(towar);
            Close();
        }
    }
}
