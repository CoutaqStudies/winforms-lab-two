using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            buttonLogIn.Visible = true;
        }
        private void textBoxLogin_Enter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
        if (e.KeyChar == (char)Keys.Return)
            {
                textBoxPassword.Select();
            }
        }
        private void textBoxPassword_Clicked(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
                textBoxPassword.ResetText();
            if (showPassword.Checked)
                textBoxPassword.PasswordChar = '\0';
            else
                textBoxPassword.PasswordChar = '*';
        }
        private void textBoxLogin_Clicked(object sender, EventArgs e)
        {
            textBoxLogin.Text = String.Empty;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
                textBoxPassword.PasswordChar = '\0';
            else
                textBoxPassword.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
