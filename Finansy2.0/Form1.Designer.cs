namespace Finansy2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            but_del1 = new Button();
            textBox1 = new TextBox();
            textBox_inc = new TextBox();
            pictureBox1 = new PictureBox();
            but_add = new Button();
            catg_incomes = new ComboBox();
            listView1 = new ListView();
            incs = new ColumnHeader();
            catg_incs = new ColumnHeader();
            comm_incs = new ColumnHeader();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            but_del2 = new Button();
            comm_exps = new TextBox();
            txt_exps = new TextBox();
            pictureBox2 = new PictureBox();
            but_substr = new Button();
            comboBox2 = new ComboBox();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            but_account = new Button();
            toolTip1 = new ToolTip(components);
            clear_all = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(850, 401);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(238, 243, 237);
            tabPage1.Controls.Add(but_del1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(textBox_inc);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(but_add);
            tabPage1.Controls.Add(catg_incomes);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(842, 373);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Доходы";
            // 
            // but_del1
            // 
            but_del1.BackColor = Color.FromArgb(90, 149, 43);
            but_del1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            but_del1.ForeColor = SystemColors.ButtonHighlight;
            but_del1.Location = new Point(187, 309);
            but_del1.Margin = new Padding(3, 2, 3, 2);
            but_del1.Name = "but_del1";
            but_del1.Size = new Size(120, 37);
            but_del1.TabIndex = 13;
            but_del1.Text = "Удалить";
            but_del1.UseVisualStyleBackColor = false;
            but_del1.Click += but_del1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(22, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 31);
            textBox1.TabIndex = 12;
            // 
            // textBox_inc
            // 
            textBox_inc.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_inc.Location = new Point(22, 65);
            textBox_inc.Name = "textBox_inc";
            textBox_inc.Size = new Size(265, 31);
            textBox_inc.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(785, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 40);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // but_add
            // 
            but_add.BackColor = Color.FromArgb(90, 149, 43);
            but_add.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            but_add.ForeColor = SystemColors.ButtonHighlight;
            but_add.Location = new Point(6, 309);
            but_add.Margin = new Padding(3, 2, 3, 2);
            but_add.Name = "but_add";
            but_add.Size = new Size(120, 37);
            but_add.TabIndex = 9;
            but_add.Text = "Добавить";
            but_add.UseVisualStyleBackColor = false;
            but_add.Click += but_add_Click_1;
            // 
            // catg_incomes
            // 
            catg_incomes.DropDownStyle = ComboBoxStyle.DropDownList;
            catg_incomes.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            catg_incomes.FormattingEnabled = true;
            catg_incomes.Items.AddRange(new object[] { "Зарплата", "Подарок", "Проценты по вкладам", "Другое" });
            catg_incomes.Location = new Point(22, 157);
            catg_incomes.Name = "catg_incomes";
            catg_incomes.Size = new Size(265, 31);
            catg_incomes.TabIndex = 7;
            catg_incomes.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { incs, catg_incs, comm_incs });
            listView1.Font = new Font("Calibri", 14F);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(331, 46);
            listView1.Name = "listView1";
            listView1.Size = new Size(505, 315);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // incs
            // 
            incs.Text = "Сумма дохода";
            incs.Width = 165;
            // 
            // catg_incs
            // 
            catg_incs.Text = "Категория дохода";
            catg_incs.TextAlign = HorizontalAlignment.Center;
            catg_incs.Width = 170;
            // 
            // comm_incs
            // 
            comm_incs.Text = "Комментарий";
            comm_incs.TextAlign = HorizontalAlignment.Center;
            comm_incs.Width = 170;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(28, 62, 15);
            label4.Location = new Point(473, 8);
            label4.Name = "label4";
            label4.Size = new Size(236, 39);
            label4.TabIndex = 4;
            label4.Text = "Список доходов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(28, 62, 15);
            label3.Location = new Point(54, 202);
            label3.Name = "label3";
            label3.Size = new Size(188, 36);
            label3.TabIndex = 3;
            label3.Text = "Комментарий";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(28, 62, 15);
            label2.Location = new Point(32, 102);
            label2.Name = "label2";
            label2.Size = new Size(235, 36);
            label2.TabIndex = 2;
            label2.Text = "Категория дохода";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(28, 62, 15);
            label1.Location = new Point(50, 11);
            label1.Name = "label1";
            label1.Size = new Size(192, 36);
            label1.TabIndex = 1;
            label1.Text = "Сумма дохода";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(238, 243, 237);
            tabPage2.Controls.Add(but_del2);
            tabPage2.Controls.Add(comm_exps);
            tabPage2.Controls.Add(txt_exps);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(but_substr);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(842, 373);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Расходы";
            // 
            // but_del2
            // 
            but_del2.BackColor = Color.FromArgb(90, 149, 43);
            but_del2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            but_del2.ForeColor = SystemColors.ButtonHighlight;
            but_del2.Location = new Point(183, 309);
            but_del2.Margin = new Padding(3, 2, 3, 2);
            but_del2.Name = "but_del2";
            but_del2.Size = new Size(120, 37);
            but_del2.TabIndex = 22;
            but_del2.Text = "Удалить";
            but_del2.UseVisualStyleBackColor = false;
            but_del2.Click += but_del2_Click;
            // 
            // comm_exps
            // 
            comm_exps.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comm_exps.Location = new Point(14, 261);
            comm_exps.Name = "comm_exps";
            comm_exps.Size = new Size(265, 31);
            comm_exps.TabIndex = 21;
            // 
            // txt_exps
            // 
            txt_exps.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txt_exps.Location = new Point(14, 61);
            txt_exps.Name = "txt_exps";
            txt_exps.Size = new Size(265, 31);
            txt_exps.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(781, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 39);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // but_substr
            // 
            but_substr.BackColor = Color.FromArgb(90, 149, 43);
            but_substr.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            but_substr.ForeColor = SystemColors.ButtonHighlight;
            but_substr.Location = new Point(6, 309);
            but_substr.Margin = new Padding(3, 2, 3, 2);
            but_substr.Name = "but_substr";
            but_substr.Size = new Size(120, 37);
            but_substr.TabIndex = 18;
            but_substr.Text = "Добавить";
            but_substr.UseVisualStyleBackColor = false;
            but_substr.Click += but_substr_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Здоровье", "Досуг", "Дом", "Кафе и рестораны", "Образование", "Такси и транспорт", "Отчисления", "Непредвиденные", "Уход за собой", "Одежда", "Прочее" });
            comboBox2.Location = new Point(14, 156);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(265, 31);
            comboBox2.TabIndex = 16;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Font = new Font("Calibri", 14F);
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(327, 45);
            listView2.Name = "listView2";
            listView2.Size = new Size(505, 315);
            listView2.TabIndex = 14;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Сумма расходов";
            columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Категория расходов";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 175;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Комментарий";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 165;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(28, 62, 15);
            label5.Location = new Point(465, 7);
            label5.Name = "label5";
            label5.Size = new Size(247, 39);
            label5.TabIndex = 13;
            label5.Text = "Список расходов";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(28, 62, 15);
            label6.Location = new Point(46, 201);
            label6.Name = "label6";
            label6.Size = new Size(188, 36);
            label6.TabIndex = 12;
            label6.Text = "Комментарий";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.FromArgb(28, 62, 15);
            label7.Location = new Point(24, 101);
            label7.Name = "label7";
            label7.Size = new Size(260, 36);
            label7.TabIndex = 11;
            label7.Text = "Категория расходов";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.FromArgb(28, 62, 15);
            label8.Location = new Point(42, 10);
            label8.Name = "label8";
            label8.Size = new Size(217, 36);
            label8.TabIndex = 10;
            label8.Text = "Сумма расходов";
            // 
            // but_account
            // 
            but_account.BackColor = Color.FromArgb(90, 149, 43);
            but_account.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            but_account.ForeColor = SystemColors.ButtonHighlight;
            but_account.Location = new Point(314, 12);
            but_account.Name = "but_account";
            but_account.Size = new Size(171, 44);
            but_account.TabIndex = 1;
            but_account.Text = "Баланс";
            toolTip1.SetToolTip(but_account, "Посмотреть баланс");
            but_account.UseVisualStyleBackColor = false;
            but_account.Click += but_account_Click;
            // 
            // clear_all
            // 
            clear_all.BackColor = Color.FromArgb(90, 149, 43);
            clear_all.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clear_all.ForeColor = SystemColors.ButtonHighlight;
            clear_all.Location = new Point(681, 12);
            clear_all.Name = "clear_all";
            clear_all.Size = new Size(171, 44);
            clear_all.TabIndex = 2;
            clear_all.Text = "Очистить";
            toolTip1.SetToolTip(clear_all, "Очисттить все");
            clear_all.UseVisualStyleBackColor = false;
            clear_all.Click += clear_all_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 216);
            ClientSize = new Size(868, 451);
            Controls.Add(clear_all);
            Controls.Add(but_account);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListView listView1;
        private ColumnHeader incs;
        private ColumnHeader catg_incs;
        private ColumnHeader comm_incs;
        private ComboBox catg_incomes;
        private Button but_account;
        private ToolTip toolTip1;
        private Button but_add;
        private Button but_substr;
        private ComboBox comboBox2;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox_inc;
        private TextBox textBox1;
        private TextBox comm_exps;
        private TextBox txt_exps;
        private Button but_del1;
        private Button but_del2;
        private Button clear_all;
    }
}
