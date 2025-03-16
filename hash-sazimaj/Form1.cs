using System;
using System.Windows.Forms;
namespace hash_sazimaj
{
    public partial class Form1 : Form
    {
        private UserManager userManager = new UserManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            User user = userManager.Authenticate(username, password);
            if (user != null)
            {
                Form2 mainForm = new Form2(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                labelErrorMessage.Text = "Neplatné přihlašovací údaje";
            }
        }
    }
}
