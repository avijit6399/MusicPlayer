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
    public partial class frmAddUser : Form
    {
        public List<User> userList = new List<User>();

        public frmAddUser()
        {
            InitializeComponent();
            this.Text = Config.getAppNameAppended("Add Edit Users");
            DBClass.getAllUserList(userList);
            putUserIntoListBox();
        }

        public void putUserIntoListBox()
        {
            listBoxUser.DataSource = null;
            listBoxUser.DataSource = userList;
            listBoxUser.DisplayMember = "userName";
            listBoxUser.ValueMember = "userIdNumber";
        }


        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void deleteSelectedUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = Utility.getListBoxSelectedIndex(listBoxUser);
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length < 4 || txtUserName.Text.Trim().Length > 15)
            {
                MessageBox.Show("Please put Username between 4 to 15 character");
                return;
            }

            if (txtPassword.Text.Trim().Length < 4 || txtPassword.Text.Trim().Length > 15)
            {
                MessageBox.Show("Please put temporary password between 4 to 15 character");
                return;
            }

            String output=DBClass.insertUser(txtUserName.Text, txtPassword.Text);

            MessageBox.Show(output);

            if (output.Equals("User sucessfully added.") == true)
            {
                DBClass.getAllUserList(userList);
                putUserIntoListBox();

                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
