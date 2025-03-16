using System;
using System.Windows.Forms;

namespace hash_sazimaj
{
    public partial class Form2 : Form
    {
        private string username;

        public Form2(string username)
        {
            InitializeComponent();
            this.username = username;
            labelWelcome.Text = $"Vítejte, {username}";
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            Form4 changePasswordForm = new Form4(username);
            changePasswordForm.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
    }
}
