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
    public partial class Фирма_поставшика : Form
    {
        DB db;
        public Фирма_поставшика(DB db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Postavshik postavshik = new Postavshik { Name = textBox7.Text, Tel_Postavshiks = new List<string>() };
            db.postavshiks.Add(postavshik);
            db.Save();
            Close();
        }
    }
}
