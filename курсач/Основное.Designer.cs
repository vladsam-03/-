namespace курсач
{
    partial class Основное
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКолвоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фирмуЗавозаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фирмуВывозаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ТелефоныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.исторяСобытийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по типу";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(327, 275);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Тип";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Наличие";
            this.columnHeader3.Width = 111;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКолвоToolStripMenuItem,
            this.отправитьТоварToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 48);
            // 
            // добавитьКолвоToolStripMenuItem
            // 
            this.добавитьКолвоToolStripMenuItem.Name = "добавитьКолвоToolStripMenuItem";
            this.добавитьКолвоToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.добавитьКолвоToolStripMenuItem.Text = "Завезти товар";
            this.добавитьКолвоToolStripMenuItem.Click += new System.EventHandler(this.добавитьКолвоToolStripMenuItem_Click);
            // 
            // отправитьТоварToolStripMenuItem
            // 
            this.отправитьТоварToolStripMenuItem.Name = "отправитьТоварToolStripMenuItem";
            this.отправитьТоварToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.отправитьТоварToolStripMenuItem.Text = "Отправить товар";
            this.отправитьТоварToolStripMenuItem.Click += new System.EventHandler(this.отправитьТоварToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.исторяСобытийToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(326, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типToolStripMenuItem,
            this.товарToolStripMenuItem,
            this.фирмуЗавозаToolStripMenuItem,
            this.фирмуВывозаToolStripMenuItem,
            this.ТелефоныToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // типToolStripMenuItem
            // 
            this.типToolStripMenuItem.Name = "типToolStripMenuItem";
            this.типToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.типToolStripMenuItem.Text = "Тип";
            this.типToolStripMenuItem.Click += new System.EventHandler(this.типToolStripMenuItem_Click);
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.товарToolStripMenuItem.Text = "Товар";
            this.товарToolStripMenuItem.Click += new System.EventHandler(this.товарToolStripMenuItem_Click);
            // 
            // фирмуЗавозаToolStripMenuItem
            // 
            this.фирмуЗавозаToolStripMenuItem.Name = "фирмуЗавозаToolStripMenuItem";
            this.фирмуЗавозаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фирмуЗавозаToolStripMenuItem.Text = "Фирму завоза";
            this.фирмуЗавозаToolStripMenuItem.Click += new System.EventHandler(this.фирмуЗавозаToolStripMenuItem_Click);
            // 
            // фирмуВывозаToolStripMenuItem
            // 
            this.фирмуВывозаToolStripMenuItem.Name = "фирмуВывозаToolStripMenuItem";
            this.фирмуВывозаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фирмуВывозаToolStripMenuItem.Text = "Фирму вывоза";
            this.фирмуВывозаToolStripMenuItem.Click += new System.EventHandler(this.фирмуВывозаToolStripMenuItem_Click);
            // 
            // ТелефоныToolStripMenuItem
            // 
            this.ТелефоныToolStripMenuItem.Name = "ТелефоныToolStripMenuItem";
            this.ТелефоныToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ТелефоныToolStripMenuItem.Text = "Телефоны";
            this.ТелефоныToolStripMenuItem.Click += new System.EventHandler(this.имяИТелефоныToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск по названию";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // исторяСобытийToolStripMenuItem
            // 
            this.исторяСобытийToolStripMenuItem.Name = "исторяСобытийToolStripMenuItem";
            this.исторяСобытийToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.исторяСобытийToolStripMenuItem.Text = "История событий";
            this.исторяСобытийToolStripMenuItem.Click += new System.EventHandler(this.исторяСобытийToolStripMenuItem_Click);
            // 
            // Основное
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 384);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Основное";
            this.Text = "Основное";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКолвоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьТоварToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem фирмуЗавозаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фирмуВывозаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ТелефоныToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem исторяСобытийToolStripMenuItem;
    }
}