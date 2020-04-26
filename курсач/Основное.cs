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
            show();
        }

        private void добавитьКолвоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Завоз_товара(db).Show();
        }

        private void отправитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Вывоз_товара(db).Show();
        }
    }
    
}
