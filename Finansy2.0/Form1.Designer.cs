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
            but_add = new Button();
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
            but_account = new Button();
            toolTip1 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 395);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(but_add);
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
            tabPage1.Size = new Size(788, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Доходы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // but_add
            // 
            but_add.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            but_add.Location = new Point(87, 307);
            but_add.Name = "but_add";
            but_add.Size = new Size(89, 37);
            but_add.TabIndex = 9;
            but_add.Text = "Добавить";
            but_add.UseVisualStyleBackColor = true;
            but_add.Click += but_add_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox2.Location = new Point(43, 253);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(188, 31);
            maskedTextBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Зарплата", "Подарок", "Проценты по вкладам", "Другое" });
            comboBox1.Location = new Point(43, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 31);
            comboBox1.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox1.Location = new Point(43, 61);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(188, 31);
            maskedTextBox1.TabIndex = 6;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Font = new Font("Calibri", 14F);
            listView1.Location = new Point(342, 45);
            listView1.Name = "listView1";
            listView1.Size = new Size(440, 311);
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
            label4.Location = new Point(456, 3);
            label4.Name = "label4";
            label4.Size = new Size(236, 39);
            label4.TabIndex = 4;
            label4.Text = "Список доходов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(43, 204);
            label3.Name = "label3";
            label3.Size = new Size(188, 36);
            label3.TabIndex = 3;
            label3.Text = "Комментарий";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 107);
            label2.Name = "label2";
            label2.Size = new Size(235, 36);
            label2.TabIndex = 2;
            label2.Text = "Категория дохода";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(39, 12);
            label1.Name = "label1";
            label1.Size = new Size(192, 36);
            label1.TabIndex = 1;
            label1.Text = "Сумма дохода";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 367);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Расходы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // but_account
            // 
            but_account.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            but_account.Location = new Point(330, 12);
            but_account.Name = "but_account";
            but_account.Size = new Size(153, 44);
            but_account.TabIndex = 1;
            but_account.Text = "Счет";
            toolTip1.SetToolTip(but_account, "Посмотреть счет");
            but_account.UseVisualStyleBackColor = true;
            but_account.Click += but_account_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(but_account);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
        private Button but_add;
        private ToolTip toolTip1;
    }
}
