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
    public partial class История_событий : Form
    {
        DB db;
        public История_событий(DB dB)
        {
            InitializeComponent();
            db = dB;
            show();
        }
        void show()
        {
            listView1.Items.Clear();
            foreach (var history in db.historys)
            {
                ListViewItem type1 = new ListViewItem(history.kto);
                type1.SubItems.Add(history.chto);
                type1.SubItems.Add(history.skoka);
                type1.Tag = history;
                listView1.Items.Add(type1);
            }
        }

            private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            History tel1 = (History)listView1.SelectedItems[0].Tag;
            db.historys.Remove(tel1);
            db.Save();
            show();
        }
    }
}
