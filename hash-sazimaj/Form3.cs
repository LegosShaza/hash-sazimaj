using System;
using System.Windows.Forms;

namespace hash_sazimaj
{
    public partial class Form3 : Form
    {
        private UserManager userManager = new UserManager();

        public Form3()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            listBoxUsers.Items.Clear();
            foreach (var user in userManager.Users)
            {
                listBoxUsers.Items.Add(user.Username);
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Form4 addUserForm = new Form4(null);
            addUserForm.Show();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
            {
                string selectedUser = listBoxUsers.SelectedItem.ToString();
                userManager.DeleteUser(selectedUser);
                LoadUsers();
            }
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
            {
                string selectedUser = listBoxUsers.SelectedItem.ToString();
                userManager.ResetPassword(selectedUser, "newpassword");
                MessageBox.Show("Heslo bylo resetováno.");
            }
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void ř(object sender, EventArgs e)
        {

        }
    }
}
