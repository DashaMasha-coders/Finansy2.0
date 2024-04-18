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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            maskedTextBox4 = new MaskedTextBox();
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
            tabControl1.Location = new Point(12, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(850, 395);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(238, 243, 237);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(maskedTextBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(842, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Доходы";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(785, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 44);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(90, 149, 43);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(80, 306);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 34);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox2.Location = new Point(22, 250);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(265, 31);
            maskedTextBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Зарплата", "Подарок", "Проценты по вкладам", "Другое" });
            comboBox1.Location = new Point(22, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 31);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox1.Location = new Point(22, 51);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(265, 31);
            maskedTextBox1.TabIndex = 6;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Font = new Font("Calibri", 14F);
            listView1.Location = new Point(331, 46);
            listView1.Name = "listView1";
            listView1.Size = new Size(505, 315);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Сумма дохода";
            columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Категория дохода";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Комментарий";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 170;
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
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(maskedTextBox3);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(maskedTextBox4);
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(842, 367);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Расходы";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(781, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 43);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(90, 149, 43);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(77, 305);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(127, 34);
            button2.TabIndex = 18;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox3.Location = new Point(14, 249);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(265, 31);
            maskedTextBox3.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Здоровье", "Досуг", "Дом", "Кафе", "Образование", "Очисления", "Непредвиденные" });
            comboBox2.Location = new Point(14, 156);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(265, 31);
            comboBox2.TabIndex = 16;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox4.Location = new Point(14, 50);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(265, 31);
            maskedTextBox4.TabIndex = 15;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Font = new Font("Calibri", 14F);
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
            columnHeader5.Text = "Категория дохода";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 170;
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
            label5.Size = new Size(236, 39);
            label5.TabIndex = 13;
            label5.Text = "Список доходов";
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
            but_account.Location = new Point(316, 12);
            but_account.Name = "but_account";
            but_account.Size = new Size(171, 44);
            but_account.TabIndex = 1;
            but_account.Text = "Баланс";
            toolTip1.SetToolTip(but_account, "Посмотреть баланс");
            but_account.UseVisualStyleBackColor = false;
            but_account.Click += but_account_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 216);
            ClientSize = new Size(868, 451);
            Controls.Add(but_account);
            Controls.Add(tabControl1);
            Name = "Form1";
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
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button but_account;
        private ToolTip toolTip1;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox3;
        private ComboBox comboBox2;
        private MaskedTextBox maskedTextBox4;
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
    }
}
