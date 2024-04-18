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
            substr = Convert.ToInt32(maskedTextBox4.Text);
            account = account - substr;
            maskedTextBox4.Clear();
            MessageBox.Show($"Баланс: {account}", "Баланс", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void but_add_Click_1(object sender, EventArgs e)
        {
            add = Convert.ToInt32(maskedTextBox1.Text);
            account = account + add;
            maskedTextBox1.Clear();
            MessageBox.Show($"Баланс: {account}", "Баланс", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
