using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hash_sazimaj
{
    public partial class Form4 : Form
    {
        private UserManager userManager = new UserManager();

        public Form4()
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

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
            {
                string selectedUser = listBoxUsers.SelectedItem.ToString();
                userManager.ResetPassword(selectedUser, "newpassword");
                MessageBox.Show("Heslo bylo resetováno na 'newpassword'.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
