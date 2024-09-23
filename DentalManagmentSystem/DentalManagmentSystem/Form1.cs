namespace DentalManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void login_Click(object sender, EventArgs e)
        {

            String user = usernameInput.Text.ToString();
            String pass = passwordInput.Text.ToString();

            if (user == "admin" && pass == "admin")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }
        private void showHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!showHidePassword.Checked)
            {
                passwordInput.UseSystemPasswordChar = true;
            }
            else
            {
                passwordInput.UseSystemPasswordChar = false;
            }
        }
    }
}