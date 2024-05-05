using System.Diagnostics.Eventing.Reader;

namespace Finansy2._0
{
    public partial class Form1 : Form
    {
        //Переменные для управления балансом счета
        int account, add, substr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Кнопка для просмотра баланса счета
        private void but_account_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Баланс: {account}", "Баланс", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        //Кнопка для добавления расходов
        private void but_substr_Click(object sender, EventArgs e)
        {
            //Проверка что во все поля введены данные
            if (string.IsNullOrEmpty(txt_exps.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(comm_exps.Text))
            {
                //Вывод сообщения об ошибке
                MessageBox.Show("Нужно ввести значения во все поля ввода!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Вызов метода доюавления всех элементов в список расходов
                add_expenses(txt_exps.Text, comboBox2.Text, comm_exps.Text);

                //Вычетание денег с баланса счета
                substr = Convert.ToInt32(txt_exps.Text);
                account = account - substr;

                //Вывод баланса счета
                MessageBox.Show($"Баланс: {account}", "Баланс", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Очистка полей ввода данных о расходах
                txt_exps.Clear();
                comboBox2.SelectedIndex = -1;
                comm_exps.Clear();
            }

        }

        //Кнопка для добавления доходов
        private void but_add_Click_1(object sender, EventArgs e)
        {
            //Проверка что во все поля введены данные
            if (string.IsNullOrEmpty(textBox_inc.Text) || string.IsNullOrEmpty(catg_incomes.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                //Вывод сообщения об ошибке
                MessageBox.Show("Нужно ввести значения во все поля ввода!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Вызов метода добавления всех элементов в список доходов
                add_incomes(textBox_inc.Text, catg_incomes.Text, textBox1.Text);

                //Добавление денег на баланс счета
                add = Convert.ToInt32(textBox_inc.Text);
                account = account + add;

                //Вывод баланса счета
                MessageBox.Show($"Баланс: {account}", "Баланс", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Очистка для полей ввода данных о доходах
                textBox_inc.Clear();
                textBox1.Clear();
                catg_incomes.SelectedIndex = -1;

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Метод для добавления всех элементов в список доходов
        private void add_incomes(string incs, string catg_incs, string comm_incs)
        {
            string[] row = { incs, catg_incs, comm_incs };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }

        //Метод для добавления всех элементов в список расходов
        private void add_expenses(string exps, string catg_exps, string comm_exps)
        {
            string[] rows = { exps, catg_exps, comm_exps };
            ListViewItem item = new ListViewItem(rows);
            listView2.Items.Add(item);
        }
        //Кнопка удаления выбранного элемента из списка доходов
        private void but_del1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        //Кнопка удаления выбранного элемента из списка расходов
        private void but_del2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.SelectedItems)
            {
                listView2.Items.Remove(item);
            }
        }
        //Кнопка для очистки всех списков и баланса счета
        private void clear_all_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (a == DialogResult.Yes) 
            {
            listView1.Items.Clear();
            listView2.Items.Clear();
            account = 0;
            }
        }

        private void textBox_inc_TextChanged(object sender, EventArgs e)
        {

        }
        //Ввод только чисел в поле для суммы дохода 
        private void textBox_inc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        //Ввод только чисел в поле для суммы расхода
        private void txt_exps_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cha = e.KeyChar;
            if (!Char.IsDigit(cha) && cha != 8)
            {
                e.Handled = true;
            }
        }
    }
}
