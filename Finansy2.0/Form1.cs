using System.Diagnostics.Eventing.Reader;

namespace Finansy2._0
{
    public partial class Form1 : Form
    {
        int account, add, substr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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

        private void but_substr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_exps.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(comm_exps.Text))
            {
                MessageBox.Show("Нужно ввести значения во все поля ввода!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                add_expenses(txt_exps.Text, comboBox2.Text, comm_exps.Text);

                substr = Convert.ToInt32(txt_exps.Text);
                account = account - substr;

                MessageBox.Show($"Баланс: {account}", "Баланс", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_exps.Clear();
                comboBox2.SelectedIndex = -1;
                comm_exps.Clear();
            }

        }


        private void but_add_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_inc.Text) || string.IsNullOrEmpty(catg_incomes.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Нужно ввести значения во все поля ввода!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                add_incomes(textBox_inc.Text, catg_incomes.Text, textBox1.Text);

                add = Convert.ToInt32(textBox_inc.Text);
                account = account + add;
                textBox_inc.Clear();
                textBox1.Clear();
                catg_incomes.SelectedIndex = -1;

                MessageBox.Show($"Баланс: {account}", "Баланс", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_incomes(string incs, string catg_incs, string comm_incs)
        {
            string[] row = { incs, catg_incs, comm_incs };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }

        private void add_expenses(string exps, string catg_exps, string comm_exps)
        {
            string[] rows = { exps, catg_exps, comm_exps };
            ListViewItem item = new ListViewItem(rows);
            listView2.Items.Add(item);
        }

        private void but_del1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void but_del2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.SelectedItems)
            {
                listView2.Items.Remove(item);
            }
        }

        private void clear_all_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            account = 0;
        }
    }
}
