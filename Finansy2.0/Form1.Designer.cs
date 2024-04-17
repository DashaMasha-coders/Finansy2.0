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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
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
            button2 = new Button();
            maskedTextBox4 = new MaskedTextBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label5 = new Label();
            but_account = new Button();
            toolTip1 = new ToolTip(components);
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 61);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(910, 527);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(maskedTextBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(902, 494);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Доходы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(92, 408);
            button1.Name = "button1";
            button1.Size = new Size(145, 45);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox2.Location = new Point(25, 333);
            maskedTextBox2.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(302, 36);
            maskedTextBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Зарплата", "Подарок", "Проценты по вкладам", "Другое" });
            comboBox1.Location = new Point(25, 209);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 37);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox1.Location = new Point(25, 68);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(302, 36);
            maskedTextBox1.TabIndex = 6;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Font = new Font("Calibri", 14F);
            listView1.Location = new Point(379, 68);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(506, 418);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Сумма дохода";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Категория дохода";
            columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Комментарий";
            columnHeader3.Width = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(496, 15);
            label4.Name = "label4";
            label4.Size = new Size(293, 49);
            label4.TabIndex = 4;
            label4.Text = "Список доходов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(25, 270);
            label3.Name = "label3";
            label3.Size = new Size(238, 45);
            label3.TabIndex = 3;
            label3.Text = "Комментарий";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(25, 138);
            label2.Name = "label2";
            label2.Size = new Size(302, 45);
            label2.TabIndex = 2;
            label2.Text = "Категория дохода";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(247, 45);
            label1.TabIndex = 1;
            label1.Text = "Сумма дохода";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(maskedTextBox4);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(maskedTextBox3);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(902, 494);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Расходы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(89, 415);
            button2.Name = "button2";
            button2.Size = new Size(169, 53);
            button2.TabIndex = 7;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox4.Location = new Point(16, 346);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(313, 36);
            maskedTextBox4.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 21F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(18, 285);
            label7.Name = "label7";
            label7.Size = new Size(226, 42);
            label7.TabIndex = 5;
            label7.Text = "Комментарий";
            label7.Click += label7_Click;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Зарплата ", "Подарок", "Проценты по вкладам", "Другое" });
            comboBox3.Location = new Point(16, 221);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(315, 36);
            comboBox3.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 21F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(18, 160);
            label6.Name = "label6";
            label6.Size = new Size(313, 42);
            label6.TabIndex = 2;
            label6.Text = "Категория расходов";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox3.Location = new Point(18, 88);
            maskedTextBox3.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(313, 36);
            maskedTextBox3.TabIndex = 1;
            maskedTextBox3.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 21F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(18, 33);
            label5.Name = "label5";
            label5.Size = new Size(262, 42);
            label5.TabIndex = 0;
            label5.Text = "Сумма расходов";
            label5.Click += label5_Click;
            // 
            // but_account
            // 
            but_account.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            but_account.Location = new Point(377, 16);
            but_account.Margin = new Padding(3, 4, 3, 4);
            but_account.Name = "but_account";
            but_account.Size = new Size(175, 59);
            but_account.TabIndex = 1;
            but_account.Text = "Счет";
            toolTip1.SetToolTip(but_account, "Посмотреть счет");
            but_account.UseVisualStyleBackColor = true;
            but_account.Click += but_account_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listView2.Location = new Point(424, 88);
            listView2.Name = "listView2";
            listView2.Size = new Size(472, 399);
            listView2.TabIndex = 8;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Сумма расходов";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Категория расходов";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Комментарий";
            columnHeader6.Width = 150;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(513, 26);
            label8.Name = "label8";
            label8.Size = new Size(307, 49);
            label8.TabIndex = 9;
            label8.Text = "Список расходов";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 601);
            Controls.Add(but_account);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private Label label5;
        private MaskedTextBox maskedTextBox3;
        private Label label6;
        private MaskedTextBox maskedTextBox4;
        private Label label7;
        private ComboBox comboBox3;
        private Button button1;
        private Button button2;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label8;
    }
}
