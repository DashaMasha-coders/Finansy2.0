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

        private void but_add_Click(object sender, EventArgs e)
        {
            add = Convert.ToInt32(maskedTextBox1.Text);
            account = account + add;
            maskedTextBox1.Clear();
        }
    }
}
