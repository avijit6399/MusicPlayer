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
    public partial class frmUpdatePassword : Form
    {
        public frmUpdatePassword()
        {
            InitializeComponent();
            this.Text = Config.getAppNameAppended("Update Password");
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if(txtOldPassword.Text.Length == 0)
            {
                MessageBox.Show("Old password is not provided");
                txtOldPassword.Focus();
                return;
            }

            if (txtNewPassword.Text.Length <= 3 || txtNewPassword.Text.Length >=16 )
            {
                MessageBox.Show("New password should be 4 to 15 character long");
                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("New password is not matching with Confirm Password. Please check.");
                txtConfirmPassword.Focus();
                return;
            }

            if (txtOldPassword.Text == txtNewPassword.Text)
            {
                MessageBox.Show("New password cannot be same with Old password.");
                txtNewPassword.Focus();
                return;
            }

            String output=DBClass.updatePassword(txtOldPassword.Text, txtNewPassword.Text);
            MessageBox.Show(output);

            if (output.Equals("Password successfully updated"))
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
