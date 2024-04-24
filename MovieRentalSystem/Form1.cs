using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MMSEntities content = new MMSEntities();

            String inputUsername = null;
            String inputPassword = null;

            if (usernameTextBox.Text != string.Empty)
            {
                inputUsername = usernameTextBox.Text;
            } else
            {
                MessageBox.Show("Username not filled!");
                return;
            }

            if (passwordTextBox.Text != string.Empty)
            {
                inputPassword = passwordTextBox.Text;
            } else
            {
                MessageBox.Show("Password not found!");
                return;
            }

            var user = content.MMSAdmins.Where(x => x.Username.Equals(usernameTextBox.Text)).FirstOrDefault();

            if (user != null)
            {
                inputPassword = inputPassword.PadRight(50, ' ');
                if (user.Password.Equals(inputPassword))
                {
                    MessageBox.Show("Logged In");
                } else
                {
                    MessageBox.Show("Invalid Password!");
                }
            } else
            {
                MessageBox.Show("User not found!");
            }

           }
    }
}
