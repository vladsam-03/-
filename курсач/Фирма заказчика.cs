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
    public partial class Фирма_заказчика : Form
    {
        DB db;
        public Фирма_заказчика(DB db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type type = new Type { Name = textBox7.Text };
            db.list.Add(type);
            Close();
        }
    }
}
