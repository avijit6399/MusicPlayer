using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MusicPlayer_1._0.classes;

namespace MusicPlayer_1._0
{
    public partial class LoginForm : Form
    {
        public bool isLoginSucessfull=false;

        public LoginForm()
        {
            InitializeComponent();
            this.Text = Config.getAppNameAppended("Login");
        }

        private void NewForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DBClass.isLoginSuccessful(txtLogin.Text, txtPassword.Text))
            {
                isLoginSucessfull = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect UserId or Password", "Access Denied...",MessageBoxButtons.OK);
            }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
