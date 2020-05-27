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
    public partial class Основное : Form
    {
        DB db = new DB();
        public Основное()
        {
            InitializeComponent();
            timer1.Start();
            show();
        }

        private void типToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Тип(db).Show();
        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Товар(db).Show();
        }
        void show() 
        {
            listView1.Items.Clear();
            foreach (Towar towar in db.towars)
            {
                ListViewItem type1 = new ListViewItem(towar.Type.Name);

                type1.SubItems.Add(towar.Name);
                type1.SubItems.Add(towar.Kolichestvo.ToString());
                type1.Tag = towar;
                listView1.Items.Add(type1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
                return;
            if (textBox1.Text != "")
                return;
            if (textBox2.Text != "")
                return;
            show();
        }

        private void добавитьКолвоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Towar towar = (Towar)listView1.SelectedItems[0].Tag;
            new Завоз_товара(db, towar).Show();
        }

        private void отправитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Towar towar = (Towar)listView1.SelectedItems[0].Tag;
            new Вывоз_товара(db,towar).Show();
        }

        private void фирмуЗавозаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Фирма_поставшика(db).Show();
        }

        private void фирмуВывозаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Фирма_заказчика(db).Show();
        }

        private void имяИТелефоныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Добавление_имени_и_телефона_фирмы(db).Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Towar тов in db.towars.Where(s => s.Type.Name.ToLower().Contains(textBox1.Text.ToLower())))
            {
                ListViewItem row = new ListViewItem(тов.Type.Name);
                row.SubItems.Add(тов.Name);
                row.SubItems.Add(тов.Kolichestvo.ToString());
                row.Tag = тов;
                listView1.Items.Add(row);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Towar тов in db.towars.Where(s => s.Name.ToLower().Contains(textBox2.Text.ToLower())))
            {
                ListViewItem row = new ListViewItem(тов.Type.Name);
                row.SubItems.Add(тов.Name);
                row.SubItems.Add(тов.Kolichestvo.ToString());
                row.Tag = тов;
                listView1.Items.Add(row);
            }
        }

        private void исторяСобытийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new История_событий(db).Show();
        }
    }
    
}
