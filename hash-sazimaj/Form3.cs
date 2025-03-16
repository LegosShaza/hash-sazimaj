using System;
using System.Windows.Forms;

namespace hash_sazimaj
{
    public partial class Form3 : Form
    {
        private User currentUser;
        private UserManager userManager = new UserManager();

        public Form3(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxNewPassword.Text;
            currentUser.PasswordHash = User.HashPassword(newPassword);
            userManager.SaveUsers();
            MessageBox.Show("Heslo bylo změněno.");
            this.Close();
        }
    }
}
