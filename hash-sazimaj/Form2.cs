using System;
using System.Windows.Forms;

namespace hash_sazimaj
{
    public partial class Form2 : Form
    {
        private User currentUser;

        public Form2(User user)
        {
            InitializeComponent();
            currentUser = user;
            labelWelcome.Text = $"Vítejte, {user.Username}";
            buttonManageUsers.Visible = user is Admin;
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            Form3 changePasswordForm = new Form3(currentUser);
            changePasswordForm.ShowDialog();
        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            Form4 manageUsersForm = new Form4();
            manageUsersForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
