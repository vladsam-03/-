﻿using System;
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
        public Вывоз_товара(DB db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Добавление_имени_и_телефона_фирмы(db).Show();
        }
    }
}
