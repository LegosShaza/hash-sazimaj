using System;
using System.Windows.Forms;

namespace hash_sazimaj
{
    public partial class Form4 : Form
    {
        private string username;
        private UserManager userManager = new UserManager();

        public Form4(string username)
        {
            InitializeComponent();
            this.username = username;
            textBoxNewUsername.Enabled = username == null;
            checkBoxIsAdmin.Visible = username == null;
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            string newUsername = textBoxNewUsername.Text;
            string newPassword = textBoxNewPassword.Text;
            bool isAdmin = checkBoxIsAdmin.Checked;

            if (username == null)
            {
                userManager.AddUser(newUsername, newPassword, isAdmin);
            }
            else
            {
                userManager.ResetPassword(username, newPassword);
            }
            this.Close();
        }
    }
}
