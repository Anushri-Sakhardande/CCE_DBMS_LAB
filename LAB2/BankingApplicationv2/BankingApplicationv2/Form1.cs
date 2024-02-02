namespace BankingApplicationv2
{
    public partial class Form1 : Form
    {
        private string AcNo = "1234";
        private string pass = "yesnomaybe";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == AcNo && passTextBox.Text == pass)
                {
                    Form2 ob = new Form2(AcNo);
                    this.Hide();
                    ob.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Account Number or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                // Log the exception or take appropriate action
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forgotTextBox.Visible = true;
            pass = forgotTextBox.Text;
            button2.Text = "Save";
        }
    }
}
